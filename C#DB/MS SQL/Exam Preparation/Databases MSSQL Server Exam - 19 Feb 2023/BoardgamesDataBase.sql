CREATE DATABASE Boardgames

USE Boardgames

---Problem 1
CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL 
)

CREATE TABLE Creators(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Email NVARCHAR(30) NOT NULL
)

CREATE TABLE PlayersRanges(
Id INT PRIMARY KEY IDENTITY,
PlayersMin INT NOT NULL,
PlayersMax INT NOT NULL
)

CREATE TABLE Addresses(
Id INT PRIMARY KEY IDENTITY,
StreetName NVARCHAR(100) NOT NULL,
StreetNumber INT NOT NULL,
Town NVARCHAR(30) NOT NULL,
Country NVARCHAR(50) NOT NULL,
ZIP INT NOT NULL
)

CREATE TABLE Publishers(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(30) UNIQUE NOT NULL,
AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL,
Website NVARCHAR(40) , 
Phone NVARCHAR(20)
)

CREATE TABLE Boardgames(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(30) NOT NULL,
YearPublished INT NOT NULL,
Rating DECIMAL(4,2) NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
PublisherId INT FOREIGN KEY REFERENCES Publishers(Id) NOT NULL,
PlayersRangeId INT FOREIGN KEY REFERENCES PlayersRanges(Id) NOT NULL 
)

CREATE TABLE CreatorsBoardgames(
CreatorId INT FOREIGN KEY REFERENCES Creators(Id) NOT NULL,
BoardgameId INT FOREIGN KEY REFERENCES Boardgames(Id) NOT NULL
PRIMARY KEY(CreatorId,BoardGameId)
)

---Problem 2
INSERT INTO Boardgames
	([Name],YearPublished,Rating,CategoryId,PublisherId,PlayersRangeId)
VALUES
	('Deep Blue' , 2019, 5.67, 1, 15, 7),
	('Paris' , 2016, 9.78, 7, 1, 5),
	('Catan: Starfarers' , 2021, 9.87, 7, 13, 6),
	('Bleeding Kansas' , 2020, 3.25, 3, 7, 4),
	('One Small Step' , 2019, 5.75, 5, 9, 2)

INSERT INTO Publishers 
	([Name],AddressId,Website,Phone)
VALUES
	('Agman Games', 5, 'www.agmangames.com', '+16546135542'),
	('Amethyst Games', 7, 'www.amethystgames.com', '+15558889992'),
	('BattleBooks', 13, 'www.battlebooks.com', '+12345678907')

--Problem 3

SELECT * FROM PlayersRanges

UPDATE PlayersRanges
SET PlayersMax += 1
WHERE PlayersMin = 2 AND PlayersMax = 2

SELECT * FROM Boardgames

UPDATE Boardgames
SET [Name] += 'V2'
WHERE YearPublished >= 2020

--Problem 4
--5
--1 16
--1 16 31 47
DELETE 
FROM CreatorsBoardgames
WHERE BoardgameId IN (1,16,31,47)

DELETE 
FROM Boardgames
WHERE PublisherId IN (1,16)

DELETE
FROM Publishers
WHERE AddressId = 5

DELETE
FROM Addresses
WHERE LEFT(Town,1) = 'L'

--PROBLEM 5

SELECT [Name],Rating
FROM Boardgames
ORDER BY YearPublished ASC, [Name] Desc

--PROBLEM 6

SELECT b.Id,b.[Name],b.YearPublished,c.Name AS [CategoryName] 
FROM Boardgames AS b
JOIN Categories AS c
ON b.CategoryId = c.Id
WHERE c.[Name] IN ('Strategy Games','Wargames')
ORDER BY b.YearPublished DESC

--PROBLEM 7

SELECT c.Id,c.FirstName + ' ' + c.LastName AS [CreatorName],c.Email
FROM CreatorsBoardgames AS cb
RIGHT JOIN Creators AS c ON cb.CreatorId = c.Id 
WHERE cb.BoardgameId IS NULL

--PROBLEM 8

SELECT TOP(5) bg.Name,bg.Rating,c.[Name] 
FROM Boardgames AS bg
JOIN PlayersRanges AS pr ON bg.PlayersRangeId = pr.Id
JOIN Categories AS c ON bg.CategoryId = c.Id
WHERE 
		bg.Rating > 7.00 AND bg.[Name] LIKE '%a%' OR
		bg.Rating > 7.50 AND pr.PlayersMin = 2 AND pr.PlayersMax = 5 
ORDER BY bg.[Name], bg.Rating DESC

--PROBLEM 9

SELECT  CONCAT_WS(' ',c.FirstName,c.LastName) AS [FullName], c.Email ,MAX(b.Rating) AS Rating
FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
JOIN Boardgames AS b ON b.Id = cb.BoardgameId
WHERE RIGHT(c.Email,4) = '.com'
GROUP BY c.FirstName,c.LastName,c.Email
ORDER BY FullName

-- SECOND WAY
WITH GamesRankedByCreator AS (
	SELECT CONCAT_WS(' ',c.FirstName,c.LastName) AS [FullName], Email,b.Rating,b.[Name], RANK() OVER (PARTITION BY Email ORDER BY b.Rating DESC) AS GameRank
	FROM Creators AS c
	JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
	JOIN Boardgames AS b ON b.Id = cb.BoardgameId
	WHERE RIGHT(c.Email,4) = '.com')

SELECT FullName,Email,Rating
FROM GamesRankedByCreator
WHERE GameRank = 1

--PROBLEM 10

SELECT c.LastName,CEILING(AVG(Rating)) AS AverageRating ,p.Name
FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
JOIN Boardgames AS b ON b.Id = cb.BoardgameId
JOIN Publishers AS p ON p.Id = b.PublisherId
WHERE p.[Name] = 'Stonemaier Games'
GROUP BY c.LastName,p.[Name]
ORDER BY AVG(Rating) DESC

--PROBLEM 11

CREATE FUNCTION udf_CreatorWithBoardgames(@name NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @totalGames INT = 
	(
		SELECT COUNT(cb.CreatorId)
		FROM CreatorsBoardgames AS cb
		JOIN Creators AS c ON c.Id = cb.CreatorId
		WHERE c.FirstName = @name
	)
	RETURN @totalGames
END

--PROBLEM 12

CREATE PROCEDURE usp_SearchByCategory
@category NVARCHAR(30)
AS
SELECT b.[Name],b.YearPublished,b.Rating,c.[Name],p.[Name],CONCAT_WS(' ',pr.PlayersMin,'people'),CONCAT_WS(' ',pr.PlayersMax,'people')
FROM Boardgames AS b
JOIN Categories AS c ON c.Id = b.CategoryId
JOIN Publishers AS p ON b.PublisherId = p.Id
JOIN PlayersRanges AS pr ON pr.Id = b.PlayersRangeId
WHERE c.[Name] = @category
ORDER BY p.[Name],b.YearPublished DESC