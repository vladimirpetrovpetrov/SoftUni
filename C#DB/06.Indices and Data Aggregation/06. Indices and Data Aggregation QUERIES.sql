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
SELECT wd.AgeGroup,COUNT(*) AS [WizardCount]
FROM
(SELECT
CASE 
WHEN [Age] Between 0 AND 10 Then '[0-10]'
WHEN [Age] Between 11 AND 20 Then '[11-20]'
WHEN [Age] Between 21 AND 30 Then '[21-30]'
WHEN [Age] Between 31 AND 40 Then '[31-40]'
WHEN [Age] Between 41 AND 50 Then '[41-50]'
WHEN [Age] Between 51 AND 60 Then '[51-60]'
ELSE '[61+]'
END AS [AgeGroup]
FROM WizzardDeposits) AS wd
GROUP BY wd.AgeGroup
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
SELECT DepositGroup,IsDepositExpired,AVG(DepositInterest) AS [AverageInterest]
FROM WizzardDeposits
WHERE DepositStartDate > '01.01.1985'
GROUP BY DepositGroup,IsDepositExpired
ORDER BY DepositGroup DESC,IsDepositExpired
--12 PROBLEM
SELECT SUM([Difference])
FROM(
SELECT FirstName AS [Host Wizard],
	DepositAmount AS [Host Wizard Deposit],
	LEAD(FirstName) OVER(ORDER BY [Id]) AS [Guest Wizard],
	LEAD(DepositAmount) OVER(ORDER BY [Id]) AS [Guest Wizard Deposit],
	DepositAmount - LEAD(DepositAmount) OVER(ORDER BY [Id]) AS [Difference] 
FROM WizzardDeposits) AS wd
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
SELECT *
INTO [EmployeesWithSalaryOver30k]
FROM Employees
WHERE Salary > 30000

DELETE FROM EmployeesWithSalaryOver30k
WHERE ManagerID = 42

UPDATE EmployeesWithSalaryOver30k
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,
	   AVG(Salary) AS [Average Salary]
  FROM EmployeesWithSalaryOver30k
GROUP BY DepartmentID
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
SELECT e.DepartmentID ,AVG(e.Salary)
FROM(
SELECT DepartmentID,Salary,
DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS [SalaryRank]
FROM Employees
) AS e
WHERE e.SalaryRank = 3
GROUP BY DepartmentID
--19 PROBLEM
SELECT TOP(10)
e.FirstName,
e.LastName,
e.DepartmentID
FROM Employees
AS e
WHERE e.Salary > (
					SELECT AVG(es.Salary)
					AS [AverageSalary]
					FROM Employees
					AS es
					WHERE es.DepartmentID = e.DepartmentID
					GROUP BY DepartmentID
				)
ORDER BY e.DepartmentID



