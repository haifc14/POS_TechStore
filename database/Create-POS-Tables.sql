DROP DATABASE IF EXISTS POSSystem
GO

CREATE DATABASE POSSystem
GO

USE POSSystem
GO

DROP TABLE IF EXISTS Customer
GO

CREATE TABLE Customer 
(
    CustomerID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(80),
    TotalPoints INT NOT NULL DEFAULT 0
)
GO

DROP TABLE IF EXISTS Employee
GO

CREATE TABLE Employee 
(
    EmployeeID INT PRIMARY KEY IDENTITY,
    Username INT NOT NULL,
    Pwd INT NOT NULL
)
GO

DROP TABLE IF EXISTS [Order]
GO

CREATE TABLE [Order]
(
    OrderNumber INT PRIMARY KEY IDENTITY,
    TotalPrice MONEY NOT NULL,
    TotalDiscount MONEY NOT NULL,
    TotalTax MONEY NOT NULL,
    CardPayment MONEY NOT NULL,
    CashPayment MONEY NOT NULL,
    PoitRedeem INT DEFAULT 0,
    PointEarned INT DEFAULT 0,
    OrdeDate DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    IsReturned INT DEFAULT 0 CHECK (IsReturned = 0 OR IsReturned = 1),
    CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
    EmployeeID INT FOREIGN KEY REFERENCES Employee(EmployeeID)
)
GO


DROP TABLE IF EXISTS Category
GO

CREATE TABLE Category
(
    CategoryID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL
)
GO

DROP TABLE IF EXISTS Brand
GO

CREATE TABLE Brand
(
    BrandID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL
)
GO



DROP TABLE IF EXISTS Product
GO

CREATE TABLE Product
(
    Barcode INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Price MONEY NOT NULL,
    Quantity INT NOT NULL,
    Tax MONEY NOT NULL,
    Discount MONEY DEFAULT 0,
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID),
    BrandID INT FOREIGN KEY REFERENCES Brand(BrandID)
)
GO

DROP TABLE IF EXISTS CustomerPurchase
GO

CREATE TABLE CustomerPurchase
(
    CustomerPurchaseID INT PRIMARY KEY IDENTITY,
    PurchaseDate DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
    Barcode INT FOREIGN KEY REFERENCES Product(Barcode)
)
GO

DROP TABLE IF EXISTS OrderItems
GO

CREATE TABLE OrderItems
(
    OrderItemsID INT PRIMARY KEY IDENTITY,
    Barcode INT FOREIGN KEY REFERENCES Product(Barcode),
    OrderNumber INT FOREIGN KEY REFERENCES [Order](OrderNumber)
    
)
GO

--------------------------------------

-- Adding data

INSERT INTO Customer (Name, TotalPoints)

VALUES 
    ('Brijesh', 5000),
    ('Hai', 4000),
    ('Pablo', 3000),
    ('Khush', 10000),
    ('Saad', 20000)
GO

INSERT INTO Employee (Username, Pwd)

VALUES 
    (11, 1234),
    (22, 1234),
    (33, 1234),
    (44, 1234),
    (55, 1234),
    (66, 1234)
GO

INSERT INTO [Order] (TotalPrice, TotalDiscount, TotalTax, CardPayment, CashPayment,
                    PoitRedeem, PointEarned, IsReturned, CustomerID)
VALUES 
    (200, 25, 10, 200, 0, 0, 200, 0, 1, 11),
    (500, 0, 45, 200, 300, 0, 500, 0, 2, 22),
    (10000, 200, 250, 5000, 5000, 20000, 10000, 0, 3, 44),
    (6000, 300, 100, 0, 6000, 0, 6000, 1, 3, 33),
    (6000, 300, 100, 0, 6000, 0, 6000, 1, 3, 22)
    

INSERT INTO Category(Name)
VALUES ('Electronic Accessories'),
        ('Desktop'),
        ('Laptop'),
        ('Printer'),
        ('Storage devices')



INSERT INTO Brand(Name)
VALUES 
    ('ASUS'),
    ('ACER'),
    ('HP'),
    ('APPLE'),
    ('SAMSUNG'),
    ('SONY')


INSERT INTO Product (Name, Price, Quantity, Tax, Discount, CategoryID, BrandID)
VALUES 
    ('KeyBoard M230', 30, 200, 1, 0, 1, 2),
    ('Apple Magic Mouse', 25, 150, 1, 2, 1, 4),
    ('HP All In One', 700, 15, 30, 0, 2, 3),
    ('HP Printer InkJet', 30, 200, 1, 0, 4, 3),
    ('Macbook Pro 2018', 4000, 20, 400, 0, 3, 4)


INSERT INTO CustomerPurchase (CustomerID, Barcode)
VALUES 
    (1, 2),
    (2, 4),
    (3, 3),
    (2, 5),
    (4, 1),
    (5, 5)
        
INSERT INTO OrderItems (Barcode, OrderNumber)
VALUES 
    (1, 1),
    (2, 1),
    (4, 2),
    (5, 2),
    (3, 3),
    (2, 3),
    (1, 4)