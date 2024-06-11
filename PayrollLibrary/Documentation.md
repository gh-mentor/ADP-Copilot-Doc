Payroll Library Project
The PayrollLibrary project is a C# library designed to model a company's payroll system. It adheres to the SOLID principles and provides functionality for a company to manage its departments, employees, and their payments.

Classes in the Project
The project contains the following classes:

Employee: This abstract class represents an employee in the company. It contains properties such as Id, ReportsTo, Name, Email, Mobile, and DepartmentId. It also includes a Payment property which is abstract and must be implemented by derived classes. The EmployeeDetails property returns a string with the employee's details.

Department: Represents a department in the company.

Company: Represents a company that has departments and employees.

Payroll: Provides functionality to pay employees in the company. It has a ProcessEmployees method that iterates over all departments and employees in a company, printing out each employee's details and payment.

SalariedEmployee: Represents an employee who is paid a fixed salary. This class inherits from the Employee class.

HourlyEmployee: Represents an employee who is paid based on the number of hours worked. This class also inherits from the Employee class.

License
The PayrollLibrary project is licensed under the MIT license, as stated in the LICENSE.md file in the project's root directory. The MIT license is a permissive license that is short and to the point. It lets people do anything they want with the code as long as they provide attribution back to the author and don’t hold the author liable.