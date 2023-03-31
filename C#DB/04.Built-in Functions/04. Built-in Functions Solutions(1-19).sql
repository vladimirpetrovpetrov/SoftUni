USE SoftUni
GO
--1
SELECT FirstName,LastName 
FROM Employees
WHERE FirstName LIKE ('Sa%')
--2
----Method 1
SELECT FirstName,LastName
FROM Employees
WHERE LastName LIKE '%ei%'
----Method 2
SELECT FirstName,LastName
FROM Employees
WHERE CHARINDEX('ei',[LastName]) > 0
--3
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3,10) AND
	  YEAR(HireDate) BETWEEN 1995 AND 2005
--4
SELECT FirstName,LastName
FROM Employees
WHERE CHARINDEX('engineer',JobTitle) = 0
--5
SELECT [Name]
FROM Towns
WHERE Len([Name]) IN (5,6)
ORDER BY [Name] 
--6
SELECT * 
FROM Towns
WHERE [Name] LIKE '[MKBE]%'
ORDER BY [Name]
--7
SELECT * 
FROM Towns
WHERE [Name] LIKE '[^RBD]%'
ORDER BY [Name]
--8
CREATE VIEW V_EmployeesHiredAfter2000 AS 
SELECT FirstName,LastName FROM Employees
WHERE YEAR(HireDate) > 2000
--9
SELECT FirstName,LastName
FROM Employees
WHERE LEN(LastName) = 5
--10
SELECT EmployeeID,FirstName,LastName,Salary ,
DENSE_RANK() OVER (PARTITION  BY e.Salary ORDER BY e.EmployeeID) AS [Rank]
FROM Employees AS e
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC
--11
SELECT * FROM (SELECT EmployeeID,FirstName,LastName,Salary ,
DENSE_RANK() OVER (PARTITION  BY e.Salary ORDER BY e.EmployeeID) AS [Rank]
FROM Employees AS e
WHERE Salary BETWEEN 10000 AND 50000
) as e
WHERE e.[Rank] = 2
ORDER BY Salary DESC
--12
USE Geography
GO

SELECT CountryName AS [Country Name],
IsoCode AS [Iso Code]
FROM Countries
WHERE LOWER(CountryName) LIKE '%a%a%a%'
ORDER BY [Iso Code]

--13
SELECT p.PeakName,
	   r.RiverName,
	   Lower(
	   CONCAT(
	   p.PeakName,	   SUBSTRING(r.RiverName,2,LEN(r.RiverName)-1)) 
	   ) AS Mix
  FROM Rivers AS r,Peaks as p
  WHERE RIGHT(p.PeakName,1) = LEFT(r.RiverName,1)
  ORDER BY Mix

--14
use Diablo
GO

SELECT TOP(50) 
[Name],
FORMAT([Start],'yyyy-MM-dd') AS [Start]
FROM Games
WHERE YEAR([Start]) IN (2011,2012)
ORDER BY [Start],[Name]

--15
  SELECT Username,
		 SUBSTRING(Email,CHARINDEX('@',Email,0)+1,LEN(Email)-CHARINDEX('@',Email,0)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider],Username

--16
SELECT Username,IpAddress
FROM Users
WHERE IpAddress LIKE '___[.][1]_%[.]_%[.]___'
ORDER BY Username
--17
SELECT 
[Name] AS Game,
CASE
    WHEN DATEPART(HOUR,[Start]) Between 0 AND 11 THEN 'Morning'
    WHEN DATEPART(HOUR,[Start]) Between 12 AND 17 THEN 'Afternoon'
    ELSE 'Evening'
END AS [Part of the Day] ,
CASE
    WHEN Duration <= 3 THEN 'Extra Short'
    WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
    WHEN Duration >= 6 THEN 'Long'
    ELSE 'Extra Long'
END AS [Duration]
FROM Games
ORDER BY [Game],[Duration],[Part of the Day]

--18
USE Orders
GO

SELECT ProductName,
	   OrderDate,
	   DATEADD(DAY,3,OrderDate) AS [Pay Due],
	   DATEADD(Month,1,OrderDate) AS [Deliver Due]
FROM Orders

--DATEADD(Part,Number,Date) 