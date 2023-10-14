CREATE DATABASE Zoo

USE Zoo

--PROBLEM 1

CREATE TABLE Owners(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
PhoneNumber VARCHAR(15) NOT NULL,
[Address] VARCHAR(50) NULL
)

CREATE TABLE AnimalTypes(
Id INT PRIMARY KEY IDENTITY,
AnimalType VARCHAR(30) NOT NULL
)

CREATE TABLE Cages(
Id INT PRIMARY KEY IDENTITY,
AnimalTypeId INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL
)

CREATE TABLE Animals(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30) NOT NULL,
BirthDate DATE NOT NULL,
OwnerId INT FOREIGN KEY REFERENCES Owners(Id) NULL,
AnimalTypeId INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL
)

CREATE TABLE AnimalsCages(
CageId INT FOREIGN KEY REFERENCES Cages(Id),
AnimalId INT FOREIGN KEY REFERENCES Animals(Id)
PRIMARY KEY(CageId,AnimalId)
)

CREATE TABLE VolunteersDepartments(
Id INT PRIMARY KEY IDENTITY,
DepartmentName VARCHAR(30) NOT NULL
)

CREATE TABLE Volunteers(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
PhoneNumber VARCHAR(15) NOT NULL,
[Address] VARCHAR(50) NULL,
AnimalId INT FOREIGN KEY REFERENCES Animals(Id) NULL,
DepartmentId INT FOREIGN KEY REFERENCES VolunteersDepartments(Id) NOT NULL
)

--PROBLEM 2

INSERT INTO Volunteers([Name], PhoneNumber, [Address], AnimalId, DepartmentId)
VALUES 
('Anita Kostova', '0896365412',	'Sofia, 5 Rosa str.',	15,	1),
('Dimitur Stoev', '0877564223',	null,	42,	4),	
('Kalina Evtimova',	'0896321112', 'Silistra, 21 Breza str.', 9,	7),
('Stoyan Tomov', '0898564100', 'Montana, 1 Bor str.', 18, 8),
('Boryana Mileva', '0888112233', null,	31,	5)

INSERT INTO Animals([Name], BirthDate, OwnerId, AnimalTypeId)
VALUES
('Giraffe',	'2018-09-21', 21, 1)	 ,
('Harpy Eagle',	'2015-04-17', 15, 3)	 ,
('Hamadryas Baboon', '2017-11-02', null,	1)	 ,
('Tuatara',	'2021-06-30', 2, 4)

--PROBLEM 3

SELECT * 
FROM Owners
WHERE [Name] = 'Kaloqn Stoqnov'
--Id = 4

UPDATE Animals
SET OwnerId = 4
WHERE OwnerId IS NULL

--PROBLEM 4

--Id 2

DELETE 
FROM Volunteers
WHERE DepartmentId = 2

DELETE 
FROM VolunteersDepartments
WHERE DepartmentName = 'Education program assistant'

--PROBLEM 5

SELECT [Name], PhoneNumber, [Address], AnimalId, DepartmentId 
FROM Volunteers
ORDER BY [Name], AnimalId, DepartmentId

--PROBLEM 6

SELECT a.[Name], [at].AnimalType, FORMAT(a.BirthDate,'dd.MM.yyyy')
FROM Animals AS a
JOIN AnimalTypes AS [at] ON [at].Id = a.AnimalTypeId
ORDER BY a.[Name]

--PROBLEM 7

SELECT TOP(5) o.[Name], COUNT(*) AS [CountOfAnimals]
FROM Owners AS o
JOIN Animals AS a ON o.Id = a.OwnerId
GROUP BY o.[Name]
ORDER BY CountOfAnimals DESC, o.[Name]

--PROBLEM 8

SELECT o.[Name] + '-' + a.[Name] AS OwnersAnimals, o.PhoneNumber, ac.CageId 
FROM Owners AS o
JOIN Animals AS a ON o.Id = a.OwnerId
JOIN AnimalTypes AS at ON a.AnimalTypeId = [at].Id
JOIN AnimalsCages AS ac ON ac.AnimalId = a.Id
WHERE [at].AnimalType = 'Mammals'
ORDER BY o.[Name], a.[Name] DESC

--PROBLEM 9

SELECT v.[Name], v.PhoneNumber, LTRIM(RIGHT(LTRIM(v.[Address]), LEN(LTRIM(v.[Address])) - 7))
FROM Volunteers AS v
JOIN VolunteersDepartments AS vd ON v.DepartmentId = vd.Id
WHERE vd.DepartmentName = 'Education program assistant' AND LEFT(LTRIM([Address]),5) = 'Sofia'
ORDER BY v.[Name]

--PROBLEM 10

SELECT a.[Name],YEAR(a.BirthDate) AS BirthYear, ant.AnimalType 
FROM Animals AS a
JOIN AnimalTypes AS ant ON ant.Id = a.AnimalTypeId
WHERE a.OwnerId IS NULL AND DATEDIFF(YEAR,a.BirthDate,'01/01/2022') < 5 AND ant.AnimalType NOT IN ('Birds')
ORDER BY a.[Name]


--PROBLEM 11

CREATE FUNCTION udf_GetVolunteersCountFromADepartment (@VolunteersDepartment VARCHAR(30))
RETURNS INT
BEGIN
	DECLARE @totalV INT= (
	SELECT COUNT(*) 
	FROM Volunteers AS v
	JOIN VolunteersDepartments AS vd ON vd.Id = v.DepartmentId
	WHERE vd.DepartmentName = @VolunteersDepartment
	)
	RETURN @totalV
END


--PROBLEM 12

CREATE PROCEDURE usp_AnimalsWithOwnersOrNot
@AnimalName VARCHAR(30)
AS
BEGIN
	DECLARE @OwnerName VARCHAR(50) = (
			SELECT o.[Name] 
			FROM Animals AS a
			LEFT JOIN Owners AS o ON o.Id = a.OwnerId
			WHERE a.[Name] = @AnimalName)
	IF @OwnerName IS NOT NULL
		BEGIN
			SELECT a.[Name], o.[Name] AS [OwnersName]
			FROM Animals AS a
			LEFT JOIN Owners AS o ON o.Id = a.OwnerId
			WHERE a.[Name] = @AnimalName
		END
	ELSE
		BEGIN
			SELECT a.[Name], ISNULL(o.[Name],'For adoption')  AS [OwnersName]
			FROM Animals AS a
			LEFT JOIN Owners AS o ON o.Id = a.OwnerId
			WHERE a.[Name] = @AnimalName
		END
END

EXEC usp_AnimalsWithOwnersOrNot 'Hippo'
EXEC usp_AnimalsWithOwnersOrNot 'Brown bear'