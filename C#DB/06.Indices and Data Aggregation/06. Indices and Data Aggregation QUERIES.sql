USE Gringotts
GO
--1 PROBLEM
SELECT COUNT(*) 
FROM WizzardDeposits
--2 PROBLEM
SELECT MAX(wd.MagicWandSize)
FROM WizzardDeposits AS wd
--3 PROBLEM
SELECT wd.DepositGroup,MAX(wd.MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup
--4 PROBLEM
SELECT TOP(2) wd.DepositGroup
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup
ORDER BY AVG(wd.MagicWandSize)
--5 PROBLEM
SELECT wd.DepositGroup,SUM(wd.DepositAmount) AS [TotalSum]
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup
--6 PROBLEM
SELECT wd.DepositGroup,SUM(wd.DepositAmount) AS [TotalSum]
FROM WizzardDeposits AS wd
WHERE wd.MagicWandCreator = 'Ollivander Family'
GROUP BY wd.DepositGroup
--7 PROBLEM
SELECT wd.DepositGroup,SUM(wd.DepositAmount) AS [TotalSum]
FROM WizzardDeposits AS wd
WHERE wd.MagicWandCreator = 'Ollivander Family'
GROUP BY wd.DepositGroup
HAVING SUM(wd.DepositAmount) < 150000
ORDER BY TotalSum DESC
--8 PROBLEM
SELECT wd.DepositGroup,wd.MagicWandCreator,MIN(wd.DepositCharge) AS [MinDepositCharge]
FROM WizzardDeposits AS wd
GROUP BY wd.DepositGroup,wd.MagicWandCreator
ORDER BY wd.MagicWandCreator,wd.DepositGroup
--9 PROBLEM

--TODO-----------

--10 PROBLEM
--With Distinct 
SELECT DISTINCT SUBSTRING(FirstName,1,1)
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
ORDER BY SUBSTRING(FirstName,1,1)
--With Group By 
SELECT SUBSTRING(FirstName,1,1)
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY SUBSTRING(FirstName,1,1)
ORDER BY SUBSTRING(FirstName,1,1)
--11 PROBLEM
SELECT DepositGroup,IsDepositExpired,AVG(DepositInterest)
FROM WizzardDeposits
WHERE DepositStartDate > '01.01.1985'
GROUP BY DepositGroup,IsDepositExpired
ORDER BY DepositGroup DESC,DepositExpirationDate
--TODO

--12 PROBLEM

--TODO

--13 PROBLEM
USE SoftUni
GO

SELECT DepartmentID,SUM(Salary) AS [TotalSalary] 
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID
--14 PROBLEM
SELECT DepartmentID,MIN(Salary) 
FROM Employees
WHERE HireDate > '01.01.2000'
GROUP BY DepartmentID
HAVING DepartmentID IN (2,5,7)
--15 PROBLEM
CREATE VIEW v_Employeess AS 
SELECT * 
FROM Employees
WHERE Salary > 30000
SELECT * FROM v_Employeess

CREATE VIEW v_EmployeessAfterDeleteManagerID AS
DELETE FROM v_Employeess
WHERE ManagerID = 42

--TODO

--16 PROBLEM
SELECT DepartmentID,MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) < 30000 OR MAX(Salary) > 70000
--17 PROBLEM
SELECT COUNT(*) AS [Count]
FROM Employees
WHERE ManagerID IS NULL
--18 PROBLEM
--Need Ranking
SELECT DepartmentID,Salary 
FROM Employees
GROUP BY DepartmentID
--TODO
--19 PROBLEM
SELECT DepartmentID,AVG(Salary)
FROM Employees
GROUP BY DepartmentID

SELECT FirstName,LastName,DepartmentID 
FROM Employees
WHERE Salary
--TODO



--3 PROBLEM
