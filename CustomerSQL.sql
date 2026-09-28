-- Step 1: Create the Database
CREATE DATABASE SedapMakanDB;
GO

-- Step 2: Use the Database
USE SedapMakanDB;
GO

-- Step 3: Create Customers Table
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    Name NVARCHAR(100) NOT NULL,             -- Customer's full name
    Email NVARCHAR(100) NOT NULL UNIQUE,     -- Unique email address
    Password NVARCHAR(100) NOT NULL,         -- Plain text password
    EWalletBalance DECIMAL(10, 2) NOT NULL DEFAULT 0.00 -- E-wallet balance
);

-- Step 4: Create MenuItems Table
CREATE TABLE MenuItems (
    MenuItemID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    Name NVARCHAR(100) NOT NULL,              -- Name of the menu item
    Category NVARCHAR(50) NOT NULL,           -- Category (e.g., Vegetarian, Italian)
    Price DECIMAL(10, 2) NOT NULL,            -- Price of the menu item
    IsAvailable BIT NOT NULL DEFAULT 1        -- Availability status (1 = Available, 0 = Not Available)
);

-- Step 5: Create Orders Table
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,    -- Auto-incrementing primary key
    CustomerID INT NOT NULL,                  -- Foreign key referencing Customers
    MenuItemID INT NOT NULL,                  -- Foreign key referencing MenuItems
    Quantity INT NOT NULL CHECK (Quantity > 0), -- Quantity of the item ordered
    TotalPrice DECIMAL(10, 2) NOT NULL,       -- Total price for the order
    Status NVARCHAR(50) NOT NULL DEFAULT 'Pending', -- Order status
    OrderDate DATETIME NOT NULL DEFAULT GETDATE(), -- Date and time the order was placed
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (MenuItemID) REFERENCES MenuItems(MenuItemID)
);

-- Step 6: Create Feedback Table
CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    CustomerID INT NOT NULL,                  -- Foreign key referencing Customers
    Message NVARCHAR(MAX) NOT NULL,           -- Feedback message
    SubmittedDate DATETIME NOT NULL DEFAULT GETDATE(), -- Date and time the feedback was submitted
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Step 7: Create RefundRequests Table
CREATE TABLE RefundRequests (
    RefundID INT IDENTITY(1,1) PRIMARY KEY,   -- Auto-incrementing primary key
    OrderID INT NOT NULL,                     -- Foreign key referencing Orders
    CustomerID INT NOT NULL,                  -- Foreign key referencing Customers
    Reason NVARCHAR(MAX) NOT NULL,            -- Reason for the refund request
    Status NVARCHAR(50) NOT NULL DEFAULT 'Pending', -- Refund status
    RequestDate DATETIME NOT NULL DEFAULT GETDATE(), -- Date and time the request was made
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Step 8: Create EWalletTransactions Table
CREATE TABLE EWalletTransactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    CustomerID INT NOT NULL,                     -- Foreign key referencing Customers
    Amount DECIMAL(10, 2) NOT NULL,              -- Transaction amount
    TransactionType NVARCHAR(50) NOT NULL CHECK (TransactionType IN ('Top-Up', 'Deduction')), -- Type of transaction
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE(), -- Date and time of the transaction
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
GO

select * from EWalletTransactions;

-- Use the SedapMakanDB database
USE SedapMakanDB;
GO

-- Insert sample customers
INSERT INTO Customers (Name, Email, Password, EWalletBalance)
VALUES 
('John Doe', 'john.doe@example.com', 'password123', 100.00),
('Jane Smith', 'jane.smith@example.com', 'password456', 50.00),
('Alice Johnson', 'alice.johnson@example.com', 'password789', 200.00);

-- Insert sample menu items
INSERT INTO MenuItems (Name, Category, Price, IsAvailable)
VALUES 
('Vegetarian Pizza', 'Vegetarian', 12.50, 1),
('Spaghetti Carbonara', 'Italian', 15.00, 1),
('Tacos', 'Mexican', 10.00, 1),
('Margarita', 'Drinks', 8.00, 1),
('Caesar Salad', 'Vegetarian', 9.50, 1),
('Lasagna', 'Italian', 14.00, 0); -- Not available

-- Insert sample orders
INSERT INTO Orders (CustomerID, MenuItemID, Quantity, TotalPrice, Status, OrderDate)
VALUES 
(1, 1, 2, 25.00, 'Completed', GETDATE() - 5),
(2, 3, 1, 10.00, 'In Progress', GETDATE() - 2),
(3, 2, 1, 15.00, 'Pending', GETDATE());

-- Insert sample feedback
INSERT INTO Feedback (CustomerID, Message, SubmittedDate)
VALUES 
(1, 'Great food and service!', GETDATE() - 3),
(2, 'The tacos were amazing!', GETDATE() - 1),
(3, 'Please add more vegetarian options.', GETDATE());

-- Insert sample refund requests
INSERT INTO RefundRequests (OrderID, CustomerID, Reason, Status, RequestDate)
VALUES 
(1, 1, 'Order was incorrect.', 'Approved', GETDATE() - 2),
(2, 2, 'Changed my mind.', 'Pending', GETDATE() - 1);

-- Insert sample e-wallet transactions
INSERT INTO EWalletTransactions (CustomerID, Amount, TransactionType, TransactionDate)
VALUES 
(1, 50.00, 'Top-Up', GETDATE() - 10),
(1, -25.00, 'Deduction', GETDATE() - 5),
(2, 30.00, 'Top-Up', GETDATE() - 7),
(2, -10.00, 'Deduction', GETDATE() - 2),
(3, 100.00, 'Top-Up', GETDATE() - 15),
(3, -15.00, 'Deduction', GETDATE());
GO

SELECT *
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'Customers';

select * from MenuItems;

select * from Feedback;