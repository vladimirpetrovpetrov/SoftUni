--1
SELECT FirstName,LastName
FROM Employees
WHERE FirstName LIKE ('sa%')
--2
SELECT FirstName,LastName
FROM Employees
WHERE LastName LIKE ('%ei%')
--3
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3,10) AND
year(HireDate) BETWEEN 1995 AND 2005 
--4
SELECT FirstName,LastName
FROM Employees
WHERE JobTitle NOT LIKE ('%engineer%')
--5
SELECT [Name]
FROM Towns
Where Len([Name]) = 5 OR Len([Name]) = 6
ORDER BY [Name]
--6
SELECT * 
FROM Towns
WHERE 
[Name] LIKE ('M%') OR 
[Name] LIKE ('K%') OR 
[Name] LIKE ('B%') OR
[Name] LIKE ('E%') 
ORDER BY [Name]
--7
SELECT * 
FROM Towns
WHERE 
[Name] NOT LIKE ('R%') AND 
[Name] NOT LIKE ('B%') AND 
[Name] NOT LIKE ('D%') 
ORDER BY [Name]
--8
CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName 
FROM Employees
WHERE YEAR(HireDate) > 2000
--9
SELECT FirstName,LastName 
FROM Employees
WHERE Len(LastName) = 5 
--10
SELECT EmployeeID,FirstName,LastName,Salary,
DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC
--11
SELECT * FROM (
SELECT EmployeeID,FirstName,LastName,Salary,
DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
) as d
WHERE d.[Rank] = 2
ORDER BY d.Salary DESC
--12
USE [Geography]
SELECT CountryName,IsoCode
FROM Countries
WHERE [CountryName] LIKE '%a%%a%%a%'
ORDER BY IsoCode
--13
--TODO
--14
USE DIABLO

SELECT TOP(50) [Name],FORMAT([Start],'yyyy-MM-dd') FROM Games
WHERE YEAR([Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name]
--TODO
--15
SELECT [Username],
SUBSTRING(Email,CHARINDEX('@',Email) + 1,Len(Email) - CHARINDEX('@',Email)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider],UserName
--16
--TODO
--17




--18
USE Orders
SELECT
ProductName,
OrderDate,
DATEADD(DAY,3,OrderDate) AS [Pay Due],
DATEADD(MONTH,1,OrderDate) AS [Deliver Due]
FROM Orders