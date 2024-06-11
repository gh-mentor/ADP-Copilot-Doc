/*
This file contains a SQL script that creates a database schema for an employee management system.
Requirements:
- SQL Server 2019 or later
- Database name: EmployeeManagement already exists
*/


/*
    Creates a table named Employees with the following columns:
    
    - Id: INT (Primary Key) - Represents the unique identifier for each employee.
    - ReportsTo: INT - Represents the identifier of the employee's supervisor.
    - Name: NVARCHAR(255) - Represents the name of the employee.
    - Email: NVARCHAR(255) - Represents the email address of the employee.
    - Mobile: NVARCHAR(255) - Represents the mobile number of the employee.
    - DepartmentId: INT - Represents the identifier of the department to which the employee belongs.
    - CreatedAt: DATETIME - Represents the creation date of the record.
    - ModifiedAt: DATETIME - Represents the last modification date of the record.
*/
CREATE TABLE Employees (
    Id INT PRIMARY KEY,
    ReportsTo INT,
    Name NVARCHAR(255),
    Email NVARCHAR(255),
    Mobile NVARCHAR(255),
    DepartmentId INT,
    -- add a created_at column to track the creation date of the record
    CreatedAt DATETIME DEFAULT GETDATE(),
    -- add a modified_at column to track the last modification date of the record
    ModifiedAt DATETIME DEFAULT GETDATE()
);

/*
    Creates a table named HourlyEmployees with the following columns:
    
    - EmployeeId: INT (Primary Key) - Represents the unique identifier for each hourly employee.
    - HourlyRate: DECIMAL(10, 2) - Represents the hourly rate of the employee.
    - HoursWorked: DECIMAL(10, 2) - Represents the number of hours worked by the employee.
*/
CREATE TABLE HourlyEmployees (
    EmployeeId INT PRIMARY KEY,
    HourlyRate DECIMAL(10, 2),
    HoursWorked DECIMAL(10, 2),
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    ManagerID INT
);

/*
    Creates a table named SalariedEmployees with the following columns:
    
    - EmployeeId: INT (Primary Key) - Represents the unique identifier for each salaried employee.
    - WeeklySalary: DECIMAL(10, 2) - Represents the weekly salary of the employee.

*/
CREATE TABLE SalariedEmployees (
    EmployeeId INT PRIMARY KEY,
    WeeklySalary DECIMAL(10, 2),
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
);
