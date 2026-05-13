USE WaterSewageManagementDB;
GO

-- Insert sample users only if they do not already exist

IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'admin@gmail.com')
BEGIN
    INSERT INTO Users (FullName, Email, Phone, Password, Role, Address, Status)
    VALUES ('System Admin', 'admin@gmail.com', '01700000001', '1234', 'Admin', 'Dhaka', 'Active');
END

IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'customer@gmail.com')
BEGIN
    INSERT INTO Users (FullName, Email, Phone, Password, Role, Address, Status)
    VALUES ('Customer One', 'customer@gmail.com', '01700000002', '1234', 'Customer', 'Mirpur', 'Active');
END

IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'service@gmail.com')
BEGIN
    INSERT INTO Users (FullName, Email, Phone, Password, Role, Address, Status)
    VALUES ('Service Officer One', 'service@gmail.com', '01700000003', '1234', 'ServiceOfficer', 'WASA Office', 'Active');
END

IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'engineer@gmail.com')
BEGIN
    INSERT INTO Users (FullName, Email, Phone, Password, Role, Address, Status)
    VALUES ('Maintenance Engineer One', 'engineer@gmail.com', '01700000004', '1234', 'MaintenanceEngineer', 'Field Office', 'Active');
END

-- Insert sample customer only if not already exists

IF NOT EXISTS (SELECT 1 FROM Customers WHERE MeterNumber = 'MTR-1001')
BEGIN
    INSERT INTO Customers (UserID, MeterNumber, HoldingNumber, ConnectionType)
    VALUES (
        (SELECT UserID FROM Users WHERE Email = 'customer@gmail.com'),
        'MTR-1001',
        'H-55/A',
        'Residential'
    );
END

-- Insert sample bill only if not already exists

IF NOT EXISTS (
    SELECT 1 FROM Bills 
    WHERE CustomerID = (SELECT CustomerID FROM Customers WHERE MeterNumber = 'MTR-1001')
    AND BillingMonth = 'May 2026'
)
BEGIN
    INSERT INTO Bills (CustomerID, BillingMonth, PreviousReading, CurrentReading, Amount, Arrears, Status)
    VALUES (
        (SELECT CustomerID FROM Customers WHERE MeterNumber = 'MTR-1001'),
        'May 2026',
        100,
        140,
        800.00,
        0.00,
        'Unpaid'
    );
END

-- Insert sample notice only if not already exists

IF NOT EXISTS (SELECT 1 FROM Notices WHERE Title = 'Water Supply Notice')
BEGIN
    INSERT INTO Notices (Title, Description, Area, NoticeType, PublishedBy)
    VALUES (
        'Water Supply Notice',
        'Water supply may be interrupted tomorrow from 10 AM to 2 PM.',
        'Mirpur',
        'Maintenance',
        (SELECT UserID FROM Users WHERE Email = 'admin@gmail.com')
    );
END