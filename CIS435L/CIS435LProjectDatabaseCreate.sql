USE [master]
GO

IF DB_ID('CIS435LProject') IS NOT NULL
ALTER DATABASE CIS435LProject 
SET SINGLE_USER 
WITH ROLLBACK IMMEDIATE
GO

IF DB_ID('CIS435LProject') IS NOT NULL
DROP DATABASE [CIS435LProject]
GO

CREATE DATABASE [CIS435LProject]
GO

USE CIS435LProject
GO

CREATE TABLE Locations (
    LocationID INT IDENTITY(1,1) PRIMARY KEY,
    LocationCode INT,
    Address VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(50)
);

CREATE TABLE AccountType (
    AccountTypeID INT IDENTITY(1,1) PRIMARY KEY,
    AccountType VARCHAR(50)
);

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeNumber INT,
    FirstName VARCHAR(20),
    LastName VARCHAR(20),
    Title VARCHAR(50),
    CanCreateNewAccount INT,
    HourlySalary FLOAT,
    Address VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(50),
    ZipCode INT,
    Email VARCHAR(100)
);

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    DateCreated DATETIME,
    AccountNumber INT,
    AccountTypeID INT,
    FName VARCHAR(20),
    LName VARCHAR(20),
    Gender VARCHAR(7),
    Address VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(50),
    PhoneNumber VARCHAR(10),
    Email VARCHAR(100),
    FOREIGN KEY (AccountTypeID) REFERENCES AccountType(AccountTypeID)
);

CREATE TABLE Deposits (
    DepositID INT IDENTITY(1,1) PRIMARY KEY,
    LocationID INT, 
    EmployeeID INT,
    CustomerID INT, 
    DepositDate DATETIME, 
    DepositAmount FLOAT,
	FOREIGN KEY (LocationID) REFERENCES Locations(LocationID),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)

);

CREATE TABLE Withdrawals (
    WithdrawalID INT IDENTITY(1,1) PRIMARY KEY, 
    LocationID INT, 
    EmployeeID INT,
    CustomerID INT,
    WithdrawalDate DATETIME,
    WithdrawalAmount FLOAT,
    WithdrawalSuccessful INT,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE CheckCashing (
    CheckCashingID INT IDENTITY(1,1) PRIMARY KEY,
    LocationID INT,
    EmployeeID INT,
    CustomerID INT,
    CheckCashingDate DATE,
    CheckCashingAmount FLOAT,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Populate AccountType
SET IDENTITY_INSERT AccountType ON;
INSERT INTO AccountType (AccountTypeID, AccountType) VALUES
(1, 'Savings'),
(2, 'Checking'),
(3, 'Business');

SET IDENTITY_INSERT AccountType OFF;

-- Populate Locations
SET IDENTITY_INSERT Locations ON;

INSERT INTO Locations (LocationID, LocationCode, Address, City, State) VALUES
(1, 101, '123 Main St', 'Springfield', 'IL'),
(2, 102, '456 Maple Ave', 'Madison', 'WI'),
(3, 103, '789 Oak St', 'Austin', 'TX'),
(4, 104, '321 Pine Rd', 'Seattle', 'WA'),
(5, 105, '654 Elm St', 'Denver', 'CO'),
(6, 106, '147 Cedar Blvd', 'Atlanta', 'GA'),
(7, 107, '258 Birch St', 'Miami', 'FL'),
(8, 108, '369 Walnut St', 'Boston', 'MA'),
(9, 109, '951 Spruce St', 'Phoenix', 'AZ'),
(10, 110, '753 Fir St', 'New York', 'NY');

SET IDENTITY_INSERT Locations OFF;

-- Populate Employees
SET IDENTITY_INSERT Employees ON;

INSERT INTO Employees (EmployeeID, EmployeeNumber, FirstName, LastName, Title, CanCreateNewAccount, HourlySalary, Address, City, State, ZipCode, Email) VALUES
(1, 1001, 'John', 'Doe', 'Manager', 1, 20.00, '100 Main St', 'Chicago', 'IL', 60601, 'john.doe@example.com'),
(2, 1002, 'Jane', 'Smith', 'Teller', 0, 15.00, '200 Maple Ave', 'Madison', 'WI', 53703, 'jane.smith@example.com'),
(3, 1003, 'Mike', 'Johnson', 'Teller', 0, 15.50, '300 Oak St', 'Austin', 'TX', 73301, 'mike.j@example.com'),
(4, 1004, 'Emily', 'Davis', 'Manager', 1, 22.00, '400 Pine Rd', 'Seattle', 'WA', 98101, 'emily.davis@example.com'),
(5, 1005, 'Chris', 'Brown', 'Teller', 0, 14.00, '500 Elm St', 'Denver', 'CO', 80201, 'chris.brown@example.com'),
(6, 1006, 'Linda', 'Wilson', 'Teller', 0, 16.00, '600 Cedar Blvd', 'Atlanta', 'GA', 30301, 'linda.wilson@example.com'),
(7, 1007, 'James', 'Miller', 'Manager', 1, 21.00, '700 Birch St', 'Miami', 'FL', 33101, 'james.miller@example.com'),
(8, 1008, 'Patricia', 'Taylor', 'Teller', 0, 15.75, '800 Walnut St', 'Boston', 'MA', 02101, 'patricia.taylor@example.com'),
(9, 1009, 'Robert', 'Anderson', 'Manager', 1, 19.00, '900 Spruce St', 'Phoenix', 'AZ', 85001, 'robert.anderson@example.com'),
(10, 1010, 'Elizabeth', 'Thomas', 'Teller', 0, 14.50, '1000 Fir St', 'New York', 'NY', 10001, 'elizabeth.thomas@example.com'),
(11, 1011, 'Joseph', 'Jackson', 'Teller', 0, 15.20, '1100 Maple St', 'Nashville', 'TN', 37201, 'joseph.jackson@example.com'),
(12, 1012, 'Sarah', 'Harris', 'Teller', 0, 15.80, '1200 Oak St', 'Orlando', 'FL', 32801, 'sarah.harris@example.com'),
(13, 1013, 'David', 'Clark', 'Manager', 1, 23.00, '1300 Pine St', 'Las Vegas', 'NV', 89101, 'david.clark@example.com'),
(14, 1014, 'Jessica', 'Lewis', 'Teller', 0, 14.90, '1400 Elm St', 'Salt Lake City', 'UT', 84101, 'jessica.lewis@example.com'),
(15, 1015, 'Daniel', 'Lee', 'Teller', 0, 15.10, '1500 Cedar St', 'Portland', 'OR', 97201, 'daniel.lee@example.com'),
(16, 1016, 'Laura', 'Walker', 'Manager', 1, 20.50, '1600 Birch St', 'San Diego', 'CA', 92101, 'laura.walker@example.com'),
(17, 1017, 'Paul', 'Hall', 'Teller', 0, 14.80, '1700 Walnut St', 'Baltimore', 'MD', 21201, 'paul.hall@example.com'),
(18, 1018, 'Amy', 'Young', 'Teller', 0, 15.30, '1800 Spruce St', 'Cincinnati', 'OH', 45201, 'amy.young@example.com'),
(19, 1019, 'Kevin', 'Allen', 'Manager', 1, 22.50, '1900 Fir St', 'Milwaukee', 'WI', 53201, 'kevin.allen@example.com'),
(20, 1020, 'Nancy', 'King', 'Teller', 0, 15.00, '2000 Maple St', 'Kansas City', 'MO', 64101, 'nancy.king@example.com'),
(21, 1021, 'Steven', 'Wright', 'Teller', 0, 15.20, '2100 Oak St', 'Tucson', 'AZ', 85701, 'steven.wright@example.com'),
(22, 1022, 'Betty', 'Scott', 'Manager', 1, 21.75, '2200 Pine St', 'Atlanta', 'GA', 30301, 'betty.scott@example.com'),
(23, 1023, 'Charles', 'Green', 'Teller', 0, 15.40, '2300 Elm St', 'San Antonio', 'TX', 78201, 'charles.green@example.com'),
(24, 1024, 'Deborah', 'Adams', 'Teller', 0, 15.60, '2400 Cedar St', 'Virginia Beach', 'VA', 23450, 'deborah.adams@example.com'),
(25, 1025, 'Brian', 'Baker', 'Manager', 1, 22.00, '2500 Birch St', 'Omaha', 'NE', 68101, 'brian.baker@example.com');

SET IDENTITY_INSERT Employees OFF;

-- Populate Customers
SET IDENTITY_INSERT Customers ON;

INSERT INTO Customers (CustomerID, DateCreated, AccountNumber, AccountTypeID, FName, LName, Gender, Address, City, State, PhoneNumber, Email) VALUES
(1, GETDATE(), 100001, 1, 'Alice', 'Johnson', 'Female', '1111 Main St', 'Chicago', 'IL', '555-1234', 'alice.j@example.com'),
(2, GETDATE(), 100002, 2, 'Bob', 'Smith', 'Male', '2222 Maple Ave', 'Madison', 'WI', '555-5678', 'bob.smith@example.com'),
(3, GETDATE(), 100003, 3, 'Charlie', 'Brown', 'Male', '3333 Oak St', 'Austin', 'TX', '555-8765', 'charlie.b@example.com'),
(4, GETDATE(), 100004, 1, 'Dana', 'White', 'Female', '4444 Pine Rd', 'Seattle', 'WA', '555-4321', 'dana.w@example.com'),
(5, GETDATE(), 100005, 2, 'Eve', 'Davis', 'Female', '5555 Elm St', 'Denver', 'CO', '555-9876', 'eve.d@example.com'),
(6, GETDATE(), 100006, 3, 'Frank', 'Taylor', 'Male', '6666 Cedar Blvd', 'Atlanta', 'GA', '555-6543', 'frank.t@example.com'),
(7, GETDATE(), 100007, 1, 'Grace', 'Wilson', 'Female', '7777 Birch St', 'Miami', 'FL', '555-3210', 'grace.w@example.com'),
(8, GETDATE(), 100008, 2, 'Henry', 'Moore', 'Male', '8888 Walnut St', 'Boston', 'MA', '555-2109', 'henry.m@example.com'),
(9, GETDATE(), 100009, 3, 'Ivy', 'Anderson', 'Female', '9999 Spruce St', 'Phoenix', 'AZ', '555-3456', 'ivy.a@example.com'),
(10, GETDATE(), 100010, 1, 'Jack', 'Thomas', 'Male', '1010 Fir St', 'New York', 'NY', '555-7890', 'jack.t@example.com'),
(11, GETDATE(), 100011, 2, 'Karen', 'Jackson', 'Female', '1111 Maple St', 'Nashville', 'TN', '555-0987', 'karen.j@example.com'),
(12, GETDATE(), 100012, 3, 'Leo', 'Harris', 'Male', '1212 Oak St', 'Orlando', 'FL', '555-5670', 'leo.h@example.com'),
(13, GETDATE(), 100013, 1, 'Mia', 'Clark', 'Female', '1313 Pine St', 'Las Vegas', 'NV', '555-8765', 'mia.c@example.com'),
(14, GETDATE(), 100014, 2, 'Nina', 'Lewis', 'Female', '1414 Elm St', 'Salt Lake City', 'UT', '555-6542', 'nina.l@example.com'),
(15, GETDATE(), 100015, 3, 'Oscar', 'Lee', 'Male', '1515 Cedar St', 'Portland', 'OR', '555-3214', 'oscar.l@example.com'),
(16, GETDATE(), 100016, 1, 'Paul', 'Walker', 'Male', '1616 Birch St', 'San Diego', 'CA', '555-1235', 'paul.w@example.com'),
(17, GETDATE(), 100017, 2, 'Quinn', 'Hall', 'Female', '1717 Walnut St', 'Baltimore', 'MD', '555-4567', 'quinn.h@example.com'),
(18, GETDATE(), 100018, 3, 'Ryan', 'Young', 'Male', '1818 Spruce St', 'Cincinnati', 'OH', '555-7891', 'ryan.y@example.com'),
(19, GETDATE(), 100019, 1, 'Sophia', 'King', 'Female', '1919 Fir St', 'Milwaukee', 'WI', '555-0981', 'sophia.k@example.com'),
(20, GETDATE(), 100020, 2, 'Tom', 'Wright', 'Male', '2020 Maple St', 'Kansas City', 'MO', '555-1236', 'tom.w@example.com'),
(21, GETDATE(), 100021, 3, 'Uma', 'Scott', 'Female', '2121 Oak St', 'Tucson', 'AZ', '555-7892', 'uma.s@example.com'),
(22, GETDATE(), 100022, 1, 'Vera', 'Adams', 'Female', '2222 Pine St', 'Atlanta', 'GA', '555-2345', 'vera.a@example.com'),
(23, GETDATE(), 100023, 2, 'Will', 'Green', 'Male', '2323 Elm St', 'San Antonio', 'TX', '555-6789', 'will.g@example.com'),
(24, GETDATE(), 100024, 3, 'Xena', 'Baker', 'Female', '2424 Cedar St', 'Virginia Beach', 'VA', '555-3457', 'xena.b@example.com'),
(25, GETDATE(), 100025, 1, 'Yara', 'Nelson', 'Female', '2525 Birch St', 'Omaha', 'NE', '555-6780', 'yara.n@example.com');

SET IDENTITY_INSERT Customers OFF;

-- Populate Deposits
SET IDENTITY_INSERT Deposits ON;

INSERT INTO Deposits (DepositID, LocationID, EmployeeID, CustomerID, DepositDate, DepositAmount) VALUES
(1, 1, 1, 1, GETDATE(), 100.00),
(2, 2, 2, 2, GETDATE(), 200.00),
(3, 3, 3, 3, GETDATE(), 150.00),
(4, 4, 4, 4, GETDATE(), 300.00),
(5, 5, 5, 5, GETDATE(), 250.00),
(6, 6, 6, 6, GETDATE(), 400.00),
(7, 7, 7, 7, GETDATE(), 350.00),
(8, 8, 8, 8, GETDATE(), 450.00),
(9, 9, 9, 9, GETDATE(), 500.00),
(10, 10, 10, 10, GETDATE(), 600.00),
(11, 1, 11, 11, GETDATE(), 700.00),
(12, 2, 12, 12, GETDATE(), 800.00),
(13, 3, 13, 13, GETDATE(), 900.00),
(14, 4, 14, 14, GETDATE(), 1000.00),
(15, 5, 15, 15, GETDATE(), 1100.00);

SET IDENTITY_INSERT Deposits OFF;

-- Populate Withdrawals
SET IDENTITY_INSERT WithDrawals ON;

INSERT INTO Withdrawals (WithdrawalID, LocationID, EmployeeID, CustomerID, WithdrawalDate, WithdrawalAmount, WithdrawalSuccessful) VALUES
(1, 1, 1, 1, GETDATE(), 50.00, 1),
(2, 2, 2, 2, GETDATE(), 30.00, 1),
(3, 3, 3, 3, GETDATE(), 70.00, 1),
(4, 4, 4, 4, GETDATE(), 40.00, 1),
(5, 5, 5, 5, GETDATE(), 20.00, 1),
(6, 6, 6, 6, GETDATE(), 80.00, 1),
(7, 7, 7, 7, GETDATE(), 90.00, 1),
(8, 8, 8, 8, GETDATE(), 60.00, 1),
(9, 9, 9, 9, GETDATE(), 100.00, 1),
(10, 10, 10, 10, GETDATE(), 110.00, 1),
(11, 1, 11, 11, GETDATE(), 120.00, 1),
(12, 2, 12, 12, GETDATE(), 130.00, 1),
(13, 3, 13, 13, GETDATE(), 140.00, 1),
(14, 4, 14, 14, GETDATE(), 150.00, 1),
(15, 5, 15, 15, GETDATE(), 160.00, 1);

SET IDENTITY_INSERT WithDrawals OFF;

-- Populate CheckCashing
SET IDENTITY_INSERT CheckCashing ON;

INSERT INTO CheckCashing (CheckCashingID, LocationID, EmployeeID, CustomerID, CheckCashingDate, CheckCashingAmount) VALUES
(1, 1, 1, 1, GETDATE(), 100.00),
(2, 2, 2, 2, GETDATE(), 200.00),
(3, 3, 3, 3, GETDATE(), 150.00),
(4, 4, 4, 4, GETDATE(), 300.00),
(5, 5, 5, 5, GETDATE(), 250.00),
(6, 6, 6, 6, GETDATE(), 400.00),
(7, 7, 7, 7, GETDATE(), 350.00),
(8, 8, 8, 8, GETDATE(), 450.00),
(9, 9, 9, 9, GETDATE(), 500.00),
(10, 10, 10, 10, GETDATE(), 600.00);

SET IDENTITY_INSERT CheckCashing OFF;