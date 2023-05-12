--------Problem 1
CREATE PROC usp_GetEmployeesSalaryAbove35000 
AS
SELECT FirstName,LastName
FROM Employees
WHERE Salary > 35000
EXEC dbo.usp_GetEmployeesSalaryAbove35000
--------Problem 2
CREATE PROC usp_GetEmployeesSalaryAboveNumber( 
	@salary DECIMAL(18,4)) 
AS
SELECT FirstName,LastName
FROM Employees
WHERE Salary >= @salary
EXEC usp_GetEmployeesSalaryAboveNumber
	@salary = 48100
--------Problem 3
CREATE PROC usp_GetTownsStartingWith(@string nvarchar(100))
AS
SELECT [Name]
FROM Towns
WHERE [Name] LIKE @string + '%';
EXEC usp_GetTownsStartingWith 'b'
--------Problem 4
CREATE PROC usp_GetEmployeesFromTown(@townName NVARCHAR(100))
AS
SELECT e.FirstName,e.LastName FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
WHERE t.Name = @townName
EXEC usp_GetEmployeesFromTown Sofia
--------Problem 1
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS NVARCHAR(8)
AS
BEGIN
	DECLARE @result NVARCHAR(8) = 'Average';
	IF @salary < 30000
	BEGIN
		SET @result = 'Low'
	END;
	IF @salary > 50000
	BEGIN
		SET @result = 'High'
	END;
	RETURN @result;
END;

SELECT Salary,dbo.ufn_GetSalaryLevel(Salary)
FROM Employees
--------Problem 6
CREATE PROC usp_EmployeesBySalaryLevel(@levelOfSalary NVARCHAR(8))
AS
SELECT FirstName
,LastName
FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary) = @levelOfSalary

EXEC usp_EmployeesBySalaryLevel 'High'
--------Problem 7


--TODO

--------Problem 8


--TODO


--------Problem 9
CREATE PROC usp_GetHoldersFullName
AS
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name]
FROM AccountHolders
EXEC dbo.usp_GetHoldersFullName
--------Problem 10
CREATE PROC usp_GetHoldersWithBalanceHigherThan (@number DECIMAL(18,4))
AS
SELECT * FROM (
SELECT ah.FirstName,ah.LastName
FROM AccountHolders AS ah
JOIN Accounts AS a ON a.AccountHolderId = ah.Id
WHERE a.Balance > @number) AS whole
ORDER BY whole.FirstName,whole.LastName

EXEC usp_GetHoldersWithBalanceHigherThan 7000
SELECT FirstName,LastName,Balance FROM AccountHolders AS ah
JOIN Accounts AS a ON ah.Id = a.AccountHolderId
ORDER BY FirstName

--TODO 
--------Problem 11
CREATE FUNCTION ufn_CalculateFutureValue (@iSum decimal, @rate float,@years INT)
RETURNS MONEY
AS
BEGIN
DECLARE @RESULT MONEY;
--FV=I×(〖(1+R)〗^T)
SET @result = @iSum * POWER((1+rate), @years);
RETURN @result
END;

--TODO



--------Problem 12


--TODO


--------Problem 13


--TODO