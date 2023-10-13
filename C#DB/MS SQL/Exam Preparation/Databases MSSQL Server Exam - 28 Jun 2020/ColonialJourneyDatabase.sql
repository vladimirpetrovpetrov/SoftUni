CREATE DATABASE ColonialJourney

USE ColonialJourney

--PROBLEM 1

CREATE TABLE Planets(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30) NOT NULL
)

CREATE TABLE Spaceports(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
PlanetId INT FOREIGN KEY REFERENCES Planets(Id) NOT NULL
)

CREATE TABLE Spaceships(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
Manufacturer VARCHAR(30) NOT NULL,
LightSpeedRate INT DEFAULT 0
)

CREATE TABLE Colonists(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
Ucn VARCHAR(10) UNIQUE NOT NULL,
BirthDate DATE NOT NULL
)

CREATE TABLE Journeys(
Id INT PRIMARY KEY IDENTITY,
JourneyStart DateTime NOT NULL,
JourneyEnd DateTime NOT NULL,
Purpose VARCHAR(11) NOT NULL,
DestinationSpaceportId INT FOREIGN KEY REFERENCES Spaceports(Id),
SpaceshipId INT FOREIGN KEY REFERENCES Spaceships(Id),
CHECK (Purpose IN ('Medical', 'Technical', 'Educational', 'Military'))
)

CREATE TABLE TravelCards (
Id INT PRIMARY KEY IDENTITY,
CardNumber CHAR(10) NOT NULL UNIQUE,
JobDuringJourney VARCHAR(8) NULL,
ColonistId INT FOREIGN KEY REFERENCES Colonists(Id) NOT NULL,
JourneyId INT FOREIGN KEY REFERENCES Journeys(Id) NOT NULL,
CHECK (JobDuringJourney IN ('Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook'))
)

--PROBLEM 2

INSERT INTO Planets([Name])
VALUES
('Mars'),
('Earth'),
('Jupiter'),
('Saturn')

INSERT INTO Spaceships([Name], Manufacturer, LightSpeedRate)
VALUES
('Golf', 'VW',	3),
('WakaWaka',	'Wakanda',	4),
('Falcon9',	'SpaceX',	1),
('Bed',	'Vidolov',	6)

--PROBLEM 3

UPDATE Spaceships
SET LightSpeedRate += 1
WHERE Id BETWEEN 8 AND 12


--PROBLEM 4

--ID 1,2,3

DELETE TravelCards
WHERE JourneyId IN (1,2,3)

DELETE TOP(3) 
FROM Journeys

--PROBLEM 5

SELECT Id,FORMAT(JourneyStart, 'dd/MM/yyyy') AS JourneyStart , FORMAT(JourneyEnd, 'dd/MM/yyyy') AS JourneyEnd 
FROM Journeys
WHERE Purpose = 'Military'
ORDER BY JourneyStart

--PROBLEM 6

SELECT c.Id,CONCAT_WS(' ', c.FirstName, c.LastName) AS ful_name
FROM Colonists AS c
JOIN TravelCards AS tc ON c.Id = tc.ColonistId
WHERE tc.JobDuringJourney = 'Pilot'
ORDER BY c.Id

--PROBLEM 7 

SELECT COUNT(*) AS [count]
FROM Colonists AS c
JOIN TravelCards AS tc ON tc.ColonistId = c.Id
JOIN Journeys AS j ON j.Id = tc.JourneyId
WHERE j.Purpose = 'Technical'

--PROBLEM 8

SELECT s.[Name],s.Manufacturer
FROM Spaceships AS s
JOIN Journeys AS j ON j.SpaceshipId = s.Id
JOIN TravelCards AS tc ON j.Id = tc.JourneyId
JOIN Colonists AS c ON c.Id = tc.ColonistId
WHERE DATEDIFF(YEAR,c.BirthDate,'01/01/2019') < 30
AND tc.JobDuringJourney = 'Pilot'
ORDER BY s.[Name]

--PROBLEM 9

SELECT p.[Name],Count(*) AS JourneysCount
FROM Journeys AS j
JOIN Spaceports AS sp ON j.DestinationSpaceportId = sp.Id
JOIN Planets AS p ON p.Id = sp.PlanetId
GROUP BY p.[Name]
ORDER BY JourneysCount DESC, p.[Name]

--PROBLEM 10

WITH RankedColonists AS (
    SELECT 
        c.FirstName + ' ' + c.LastName AS FullName,
        tc.JobDuringJourney,
        DENSE_RANK() OVER (ORDER BY c.BirthDate) as OldestRank,
        ROW_NUMBER() OVER (PARTITION BY tc.JobDuringJourney ORDER BY c.BirthDate) as JobRank
    FROM Colonists c
    JOIN TravelCards tc ON c.Id = tc.ColonistId
)
SELECT 
    rc.JobDuringJourney,
    rc.FullName,
    rc.JobRank as JobRank
FROM RankedColonists rc
WHERE rc.JobRank = 2;

--PROBLEM 11

CREATE FUNCTION dbo.udf_GetColonistsCount(@PlanetName VARCHAR (30)) 
RETURNS INT
AS
BEGIN
	DECLARE @totalColonists INT = 
	(
		SELECT Count(*)
		FROM TravelCards AS tc
		JOIN Journeys AS j ON j.Id = tc.JourneyId
		JOIN Spaceports AS sp ON sp.Id = j.DestinationSpaceportId
		JOIN Planets AS p ON p.Id = sp.PlanetId
		WHERE p.[Name] = @PlanetName
	)
	RETURN @totalColonists
END

--'Otroyphus'

SELECT dbo.udf_GetColonistsCount('Otroyphus')

--PROBLEM 11

CREATE PROCEDURE usp_ChangeJourneyPurpose
@JourneyId INT,
@NewPurpose VARCHAR(11)
AS
BEGIN
	DECLARE @totalIds INT = (
		SELECT COUNT(*) 
		FROM Journeys)
		IF @JourneyId > @totalIds OR @JourneyId < 0
		BEGIN
			RAISERROR('The journey does not exist!', 16, 1);
		END
		--FROM HERE MEETS THE FIRST REQ
		ELSE
		BEGIN
			DECLARE @currentPurpose VARCHAR(11) = (
			SELECT Purpose 
			FROM Journeys
			WHERE Id = @JourneyId
			)
				IF @NewPurpose = @currentPurpose
				BEGIN
					RAISERROR('You cannot change the purpose!',16,1);
				END
				ELSE
				BEGIN
					UPDATE Journeys
					SET Purpose = @NewPurpose
					WHERE Id = @JourneyId
				END

		END
END
EXEC usp_ChangeJourneyPurpose 4, 'Technical'
EXEC usp_ChangeJourneyPurpose 2, 'Educational'
EXEC usp_ChangeJourneyPurpose 196, 'Technical'
