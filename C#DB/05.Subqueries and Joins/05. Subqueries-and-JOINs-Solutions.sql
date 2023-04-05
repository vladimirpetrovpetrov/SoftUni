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

SELECT ccm.CountryCode
FROM
(
SELECT *
FROM Mountains AS m
JOIN MountainsCountries AS mc
ON m.Id = mc.MountainId
JOIN Countries AS c
ON mc.CountryCode = c.CountryCode
GROUP BY c.CountryCode
) 

--TODO