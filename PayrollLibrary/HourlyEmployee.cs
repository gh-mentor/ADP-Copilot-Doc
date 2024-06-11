namespace PayrollLibrary
{
    /// <summary>
    /// Represents an hourly employee.
    /// </summary>
    public class HourlyEmployee : Employee
    {
        private double _HourlyRate;
        private double _HoursWorked;

        /// <summary>
        /// Gets or sets the hourly rate for the employee.
        /// </summary>
        public double HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }

        /// <summary>
        /// Gets or sets the number of hours worked by the employee.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is negative.</exception>
        /// <example>
        /// This sample shows how to set the HoursWorked property.
        /// <code>
        /// HourlyEmployee employee = new HourlyEmployee();
        /// employee.HoursWorked = 40;  
        /// </code>
        /// </example>
        public double HoursWorked
        {
            get { return _HoursWorked; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours worked cannot be negative.");
                }
                _HoursWorked = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the HourlyEmployee class with the specified parameters.
        /// </summary>
        /// <param name="id">The employee's ID.</param>
        /// <param name="reportsTo">The ID of the employee's supervisor.</param>
        /// <param name="name">The employee's name.</param>
        /// <param name="email">The employee's email address.</param>
        /// <param name="mobile">The employee's mobile number.</param>
        /// <param name="departmentId">The ID of the department the employee belongs to.</param>
        /// <param name="hourlyRate">The hourly rate for the employee.</param>
        /// <param name="hoursWorked">The number of hours worked by the employee.</param>
        public HourlyEmployee(int? id, int? reportsTo, string? name, string? email, string? mobile, int? departmentId, double hourlyRate = 0, double hoursWorked = 0)
            : base(id, reportsTo, name, email, mobile, departmentId)
        {
            _HourlyRate = hourlyRate;
            _HoursWorked = hoursWorked;
        }

        /// <summary>
        /// Initializes a new instance of the HourlyEmployee class with default values.
        /// </summary>
        public HourlyEmployee() : base(null, null, null, null, null, null) { }

        /// <summary>
        /// Gets the payment amount for the employee.
        /// </summary>
        public override double Payment { get { return _HourlyRate * _HoursWorked; } }

        /// <summary>
        /// Gets the details of the employee, including the hourly rate and hours worked.
        /// </summary>
        public override string EmployeeDetails
        {
            get
            {
                return base.EmployeeDetails + $", Hourly Rate: {_HourlyRate}, Hours Worked: {_HoursWorked}";
            }
        }
    }
}
