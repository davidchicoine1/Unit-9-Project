USE [Northwind]

-- 1... Creating Roles
IF DATABASE_PRINCIPAL_ID('SalesRole') IS NULL
CREATE ROLE SalesRole
GO
IF DATABASE_PRINCIPAL_ID('HRRole') IS NULL
CREATE ROLE HRRole
GO
IF DATABASE_PRINCIPAL_ID('CEORole') IS NULL
CREATE ROLE CEORole
GO

-- 2... Granting Permissions to Roles
GRANT SELECT ON dbo.Orders TO SalesRole
GRANT SELECT ON dbo.Customers TO SalesRole
GRANT SELECT ON dbo.Employees TO HRRole
GRANT SELECT ON dbo.Orders TO CEORole
GRANT SELECT ON dbo.Customers TO CEORole
GRANT SELECT ON dbo.Employees TO CEORole

-- 3... Create Users
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'User_CEO' and type = 'S')
BEGIN
CREATE LOGIN [User_CEO] WITH PASSWORD = '123';
CREATE USER [User_CEO] FOR LOGIN [User_CEO];
END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'User_HR' and type = 'S')
BEGIN
CREATE LOGIN [User_HR] WITH PASSWORD = '123';
CREATE USER [User_HR] FOR LOGIN [User_HR];
END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'User_Sales' and type = 'S')
BEGIN
CREATE LOGIN [User_Sales] WITH PASSWORD = '123';
CREATE USER [User_Sales] FOR LOGIN [User_Sales];
END
GO

-- 4... Add Users to Roles
ALTER ROLE SalesRole ADD MEMBER User_Sales;
GO
ALTER ROLE HRRole ADD MEMBER User_HR;
GO
ALTER ROLE CEORole ADD MEMBER User_CEO;
GO