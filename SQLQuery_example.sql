CREATE DATABASE Store
GO

Use Store
GO

CREATE TABLE Products
(
	Id INT IDENTITY (1, 1) PRIMARY KEY, 
	ProductName NVARCHAR(128) NOT NULL,
)


CREATE TABLE Categories
(
	Id INT IDENTITY (1, 1) PRIMARY KEY, 
	CategoryName NVARCHAR(128) NOT NULL,
)
GO

CREATE TABLE Category_Product
(
	CategoryId INT NOT NULL,
	ProductId INT NOT NULL,
	FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
	FOREIGN KEY (ProductId) REFERENCES Products(Id)
)
GO

SET IDENTITY_INSERT dbo.Products ON;  
INSERT INTO Products(Id, ProductName) VALUES
(1, '�������'),
(2, '��������'),
(3, '����������'),
(4, '���������'),
(5, '�����������'),
(6, '�������'),
(7, '����'),
(8, '���� ������������'),
(9, '����������'),
(10, '�������')
SET IDENTITY_INSERT dbo.Products OFF;  

SET IDENTITY_INSERT dbo.Categories ON;  
INSERT INTO Categories(Id, CategoryName) VALUES
(1, '������������ �������'),
(2, '������������'),
(3, '���������'),
(4, '������� �������'),
(5, '������')
SET IDENTITY_INSERT dbo.Categories OFF;  
GO

INSERT INTO Category_Product(ProductId, CategoryId) VALUES
(1, 1),
(2, 5),
(4, 5),
(5, 4),
(6, 2),
(6, 3),
(8, 3),
(9, 3),
(9, 5),
(10, 1),
(10, 5)
GO

SELECT ProductName, CategoryName FROM (Products LEFT JOIN Category_Product ON (ProductId = Id)) 
LEFT JOIN Categories ON (dbo.Categories.Id = CategoryId);
