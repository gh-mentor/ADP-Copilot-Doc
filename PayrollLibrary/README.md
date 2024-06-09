<!--
This file documents the design and implementation of the PayrollLibrary project. 
Details:
- The project contains related classes that provides functionality for a company to manage hourly and salaried employees.
- The library is implemented in C# and adheres to the SOLID principles.
- This document also includes details of the classes,  usage and license information.
-->

# Payroll Library

The Payroll Library project provides functionality for a company to manage hourly and salaried employees. The library is implemented in C# and adheres to the SOLID principles.

## Classes

The library contains the following classes:

- `Company` - Represents a company.
- `Department` - Represents a department in a company.
- `Employee` - Base class for all employees.
- `HourlyEmployee` - Represents an hourly employee.
- `SalariedEmployee` - Represents a salaried employee.
- `Payroll` - Provides functionality to calculate payroll for employees.

## Usage

To use the Payroll Library in your project, follow these steps:

1. Add a reference to the PayrollLibrary.dll in your project.

2. Create instances of the `Company`, `Department`, `HourlyEmployee`, `SalariedEmployee`, and `Payroll` classes as needed.

3. Use the `Payroll` class to calculate payroll for employees.

Example:

```csharp
Company company = new Company("ABC Corp");
Department department = new Department("Engineering");
HourlyEmployee hourlyEmployee = new HourlyEmployee("John Doe", 20.0);
SalariedEmployee salariedEmployee = new SalariedEmployee("Jane Smith", 50000.0);
Payroll payroll = new Payroll();

department.AddEmployee(hourlyEmployee);
department.AddEmployee(salariedEmployee);

company.AddDepartment(department);

decimal totalPayroll = payroll.CalculatePayroll(company);

Console.WriteLine($"Total payroll for {company.Name}: {totalPayroll}");
```
