namespace PayrollLibrary
{
    public class HourlyEmployee : Employee
    {
        private double _HourlyRate;
        private double _HoursWorked;

        public double HourlyRate { get { return _HourlyRate; } }
        public double HoursWorked { get { return _HoursWorked; } }

        public HourlyEmployee(int? id, int? reportsTo, string? name, string? email, string? mobile, int? departmentId, double hourlyRate=0, double hoursWorked=0)
            : base(id, reportsTo, name, email, mobile, departmentId)
        {
            _HourlyRate = hourlyRate;
            _HoursWorked = hoursWorked;
        }

        public override double Payment { get { return _HourlyRate * _HoursWorked; } }


        // override the EmployeeDetails property
        public override string EmployeeDetails
        {
            get
            {
                return base.EmployeeDetails + $", Hourly Rate: {_HourlyRate}, Hours Worked: {_HoursWorked}";
            }
        }

    }
}
