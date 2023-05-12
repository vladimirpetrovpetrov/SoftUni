--1
SELECT TOP(5) e.EmployeeID,
e.JobTitle,
e.AddressID,
a.AddressText
FROM Employees AS e 
JOIN Addresses AS a
ON e.AddressID = a.AddressID
ORDER BY e.AddressID
--2
SELECT TOP(50) e.FirstName,
e.LastName,
t.[Name] AS [Town],
a.AddressText
FROM Employees AS e
JOIN Addresses AS a
ON e.AddressID = a.AddressID
JOIN Towns AS t
ON a.TownID = t.TownID
ORDER BY FirstName,LastName
--3
SELECT e.EmployeeID,
e.FirstName,
e.LastName,
d.[Name] AS [DepartmentName]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY EmployeeID
--4
SELECT TOP(5) e.EmployeeID,
e.FirstName,
e.Salary,
d.[Name] AS [DepartmentName]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY e.DepartmentID
--5
SELECT TOP(3) e.EmployeeID,
e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
WHERE ep.ProjectID IS NULL
ORDER BY e.EmployeeID
--6
SELECT e.FirstName,
e.LastName,
e.HireDate,
d.[Name] AS [DeptName]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '1999/1/1' AND
d.[Name] IN ('Sales','Finance')
ORDER BY e.HireDate
--7
SELECT TOP(5) e.EmployeeID,
e.FirstName,
p.[Name] AS [ProjectName]
FROM Employees AS e
JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p
ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '2002-08-13' AND
p.EndDate IS NULL
ORDER BY e.EmployeeID
--8
SELECT e.EmployeeID,
e.FirstName,
CASE
    WHEN YEAR(p.StartDate) >= 2005 THEN NULL
    ELSE p.[Name]
END
AS [ProjectName]
FROM Employees AS e
JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p
ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24
--9
SELECT 
e.EmployeeID,
e.FirstName,
e.ManagerID,
m.FirstName AS [ManagerName]
FROM Employees AS e
JOIN Employees AS m
ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3,7)
ORDER BY EmployeeID
--10
SELECT TOP(50) e.EmployeeID,
CONCAT(e.FirstName,' ',e.LastName) AS [EmployeeName],
CONCAT(m.FirstName,' ',m.LastName) AS [ManagerName],
d.[Name] AS [DepartmentName]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
JOIN Employees AS m
ON e.ManagerID = m.EmployeeID
ORDER BY EmployeeID
--11
SELECT MIN(asd.AvgSalary)FROM
(
SELECT AVG(e.Salary) AS [AvgSalary] FROM Employees AS e
GROUP BY e.DepartmentID
) AS asd
--12
USE Geography
GO
SELECT 
c.CountryCode,
m.MountainRange,
p.PeakName,
p.Elevation
FROM Peaks AS p
JOIN MountainsCountries AS mc
ON p.MountainId = mc.MountainId
JOIN Mountains  AS m
ON mc.MountainId = m.Id
JOIN Countries AS c
ON mc.CountryCode = c.CountryCode
WHERE c.CountryName = 'Bulgaria' AND
p.Elevation > 2835
ORDER BY p.Elevation DESC
--13
SELECT mc.CountryCode,
COUNT(mc.MountainId) AS [MountainRanges]
FROM MountainsCountries AS mc
JOIN Countries AS c
ON mc.CountryCode = c.CountryCode
WHERE c.CountryName IN ('United States','Russia','Bulgaria')
GROUP BY mc.CountryCode
--14
SELECT TOP(5)
c.CountryName,
r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r
ON cr.RiverId = r.Id
JOIN Continents AS ct
ON c.ContinentCode = ct.ContinentCode
WHERE ct.ContinentName = 'Africa'
ORDER BY c.CountryName 
--15
SELECT [ContinentCode],[CurrencyCode],[CurrencyCount] 
FROM
(
SELECT *,
DENSE_RANK() OVER (PARTITION BY [ContinentCode] ORDER BY [CurrencyCount] DESC)  AS CurRank
FROM 
			(
			SELECT c.ContinentCode,
				c.CurrencyCode,
			COUNT(*) AS CurrencyCount
			FROM Countries AS c
			GROUP BY c.ContinentCode,CurrencyCode
			HAVING COUNT(*) > 1

			) AS [CurrencyUsgSQ]
) AS [CurRankingSQ]
WHERE [CurRank] = 1

--16

WITH CTE_AllCountries AS
(
	SELECT COUNT(*) AS a FROM Countries
),

CTE_CountriesWithMountains AS 
(
	SELECT COUNT(DISTINCT CountryCode) AS b FROM MountainsCountries
)

SELECT a - b AS CountryCode FROM CTE_AllCountries
JOIN CTE_CountriesWithMountains
ON a IS NOT NULL

--17
SELECT TOP(5) c.CountryName,
MAX(p.Elevation) AS [HighestPeakElevation],
MAX(r.Length) AS [LongestRiverLength]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m
ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p
ON m.Id = p.MountainId
LEFT JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r
ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY [HighestPeakElevation] DESC,[LongestRiverLength] DESC, c.CountryName


--18
SELECT TOP(5) 
[CountryName] AS [Country],
CASE
WHEN [PeakName] IS NULL THEN '(no highest peak)'
ELSE [PeakName] 
END AS [Highest Peak Name],

CASE
WHEN [Elevation] IS NULL THEN 0
ELSE [Elevation] 
END AS [Highest Peak Elevation],

CASE
WHEN [MountainRange] IS NULL THEN '(no mountain)'
ELSE [MountainRange] 
END AS [Mountain]

FROM (


SELECT c.CountryName ,
	   p.PeakName,
	   p.Elevation,
	   m.MountainRange,
	   DENSE_RANK() OVER (PARTITION  BY c.CountryName ORDER BY p.Elevation DESC) AS [PeakRank]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m
ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p
ON m.Id = p.MountainId
) AS [PeakRankingSubQuery]
WHERE [PeakRank] = 1
ORDER BY [Country],[Highest Peak Name]