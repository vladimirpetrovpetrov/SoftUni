CREATE DATABASE TouristAgency

USE TouristAgency

--PROBLEM 1
CREATE TABLE Countries(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Destinations(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL,
CountryId INT FOREIGN KEY REFERENCES Countries(Id) NULL
)

CREATE TABLE Rooms(
Id INT PRIMARY KEY IDENTITY,
[Type] VARCHAR(40) NOT NULL,
Price DECIMAL(18,2) NOT NULL,
BedCount INT NOT NULL CHECK (BedCount > 0 AND BedCount <= 10)
)

CREATE TABLE Hotels(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
DestinationId INT FOREIGN KEY REFERENCES Destinations(Id) NOT NULL
)

CREATE TABLE Tourists(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(80) NOT NULL,
PhoneNumber VARCHAR(20) NOT NULL,
Email VARCHAR(80) Null,
CountryId INT FOREIGN KEY REFERENCES Countries(Id) NOT NULL
)

CREATE TABLE Bookings(
Id INT PRIMARY KEY IDENTITY,
ArrivalDate DATETIME2 NOT NULL,
DepartureDate DATETIME2 NOT NULL,
AdultsCount INT NOT NULL CHECK (AdultsCount >= 1 AND AdultsCount <= 10),
ChildrenCount INT NOT NULL CHECK (ChildrenCount >= 0 AND ChildrenCount <= 9),
TouristId INT FOREIGN KEY REFERENCES Tourists(Id) NOT NULL,
HotelId INT FOREIGN KEY REFERENCES Hotels(Id) NOT NULL,
RoomId INT FOREIGN KEY REFERENCES Rooms(Id) NOT NULL
)

CREATE TABLE HotelsRooms(
HotelId INT FOREIGN KEY REFERENCES Hotels(Id) NOT NULL,
RoomId INT FOREIGN KEY REFERENCES Rooms(Id) NOT NULL
PRIMARY KEY (HotelId,RoomId)
)

--PROBLEM 2
INSERT INTO Tourists ([Name], PhoneNumber, Email, CountryId)
VALUES
('John Rivers',	'653-551-1555',	'john.rivers@example.com',	6	 ),
('Adeline Aglaé',	'122-654-8726',	'adeline.aglae@example.com',	2	 ),
('Sergio Ramirez',	'233-465-2876',	's.ramirez@example.com',	3	 ),
('Johan Müller',	'322-876-9826',	'j.muller@example.com',	7		 ),
('Eden Smith',	'551-874-2234',	'eden.smith@example.com',	6		 )

INSERT INTO Bookings(ArrivalDate,DepartureDate,AdultsCount,ChildrenCount,TouristId,HotelId,RoomId)
VALUES
('2024-03-01',	'2024-03-11',	1,	0,	21,	3	, 5		 )	 ,
('2023-12-28',	'2024-01-06',	2,	1,	22,	13	, 3		 )	 ,
('2023-11-15',	'2023-11-20',	1,	2,	23,	19	, 7		 )	 ,
('2023-12-05',	'2023-12-09',	4,	0,	24,	6	, 4		 )	 ,
('2024-05-01',	'2024-05-07',	6,	0,	25,	14	, 6		 )

--PROBLEM 3

UPDATE Bookings
SET DepartureDate = DATEADD(day, 1, DepartureDate)
WHERE MONTH(ArrivalDate)= 12 AND  YEAR(ArrivalDate) = 2023

UPDATE Tourists
SET Email = NULL
WHERE [Name] LIKE '%MA%'

--PROBLEM 4

--ID 6 16 25

DELETE
FROM Bookings
WHERE TouristId IN (6,16,25)

DELETE
FROM Tourists
WHERE [Name] LIKE '%Smith'

--PROBLEM 5
SELECT FORMAT(ArrivalDate, 'yyyy-MM-dd') AS ArrivalDate ,AdultsCount,ChildrenCount
FROM Bookings AS b
JOIN Rooms AS r ON r.Id = b.RoomId
ORDER BY r.Price DESC, b.ArrivalDate

--PROBLEM 6
SELECT h.Id,h.[Name] 
FROM Hotels AS h
JOIN HotelsRooms AS hr ON h.Id = hr.HotelId
JOIN Rooms AS r ON r.Id = hr.RoomId
JOIN Bookings AS b ON h.Id = b.HotelId
WHERE r.[Type] = 'VIP Apartment'
GROUP BY h.Id, h.[Name]
ORDER BY COUNT(b.Id) DESC

SELECT * FROM Hotels
SELECT * FROM Bookings
SELECT * FROM Rooms

--PROBLEM 7

SELECT t.Id,t.[Name],t.PhoneNumber 
FROM Tourists AS t
LEFT JOIN Bookings AS b ON b.TouristId = t.Id
WHERE ArrivalDate IS NULL
ORDER BY t.[Name] 


--PROBLEM 8

SELECT TOP(10) h.[Name] AS HotelName, d.[Name] AS DestinationName, c.[Name] AS CountryName
FROM Bookings AS b
JOIN Hotels AS h ON b.HotelId = h.Id
JOIN Destinations AS d ON h.DestinationId = d.Id
JOIN Countries AS c ON c.Id = d.CountryId
WHERE 
		HotelId % 2 = 1 AND 
		YEAR(ArrivalDate) <= 2023 AND
		MONTH(ArrivalDate) <= 12 AND
		DAY(ArrivalDate) < 31
ORDER BY c.[Name], b.ArrivalDate
	
--PROBLEM 9

SELECT h.[Name] AS HotelName,  r.Price
FROM Tourists AS t
JOIN Bookings AS b ON t.Id = b.TouristId
JOIN Hotels AS h ON b.HotelId = h.Id
JOIN Rooms AS r ON r.Id = b.RoomId
WHERE t.[Name] NOT LIKE '%EZ'
ORDER BY r.Price DESC

--PROBLEM 10


SELECT h.[Name] AS Name,SUM(DATEDIFF(day, b.ArrivalDate, b.DepartureDate) * r.Price) as TotalRevenue
FROM Bookings AS b
LEFT JOIN Hotels AS h ON b.HotelId = h.Id
LEFT JOIN Rooms AS r ON r.Id = b.RoomId
GROUP BY h.Name
ORDER BY TotalRevenue DESC;

--PROBLEM 11
CREATE FUNCTION udf_RoomsWithTourists(@name VARCHAR(40))  
RETURNS INT
AS
BEGIN
	DECLARE @totalTourists INT = 
	(
		SELECT SUM(AdultsCount+ChildrenCount) 
		FROM Tourists AS t
		JOIN Bookings AS b ON t.Id = b.TouristId
		JOIN Rooms AS r ON r.Id = b.RoomId
		WHERE r.[Type] = @name
	)
	RETURN @totalTourists
END
SELECT dbo.udf_RoomsWithTourists('Double Room')

--PROBLEM 12

CREATE PROCEDURE usp_SearchByCountry
@country NVARCHAR(50)
AS
BEGIN
	SELECT  t.Name, t.PhoneNumber, t.Email,COUNT(b.Id) as CountOfBookings
	FROM Tourists AS t
	JOIN Bookings AS b ON t.Id = b.TouristId
	JOIN Hotels AS h ON b.HotelId = h.Id
	JOIN Destinations AS d ON h.DestinationId = d.Id
	JOIN Countries AS c ON t.CountryId = c.Id
	WHERE c.[Name] = @country
	GROUP BY t.[Name], t.PhoneNumber, t.Email
	ORDER BY t.[Name] , CountOfBookings DESC
END
EXEC usp_SearchByCountry 'Greece'

