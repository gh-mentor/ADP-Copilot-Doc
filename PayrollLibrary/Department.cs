namespace PayrollLibrary
{

    public class Department
    {
        private int? _Id;
        private string? _Name;

        public int? Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string? Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Department(int? id = null, string? name = null)
        {
            _Id = id;
            _Name = name;
        }
    }
}
