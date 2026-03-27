namespace Administration_RRHH.Domain
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private string _identityCard;
        private string _address;
        private System.DateOnly _birthDate;
        private string _maritalStatus;
        private int _numberChildren;
        private string _email;
        private string _phone;
        private bool _status;

        public Employee()
        {
            throw new System.NotImplementedException();
        }

        public string Address
        {
            get => default;
            set
            {
            }
        }

        public System.DateOnly BirthDate
        {
            get => default;
            set
            {
            }
        }

        public string Email
        {
            get => default;
            set
            {
            }
        }

        public string IdentityCard
        {
            get => default;
            set
            {
            }
        }

        public string MaritalStatus
        {
            get => default;
            set
            {
            }
        }

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public string Phone
        {
            get => default;
            set
            {
            }
        }

        public int Surname
        {
            get => default;
            set
            {
            }
        }

        public int NumberChildren
        {
            get => default;
            set
            {
            }
        }

        public bool Status
        {
            get => default;
            set
            {
            }
        }

        public bool AddEmployee()
        {
            throw new System.NotImplementedException();
        }

        public bool TerminateEmployee(string id)
        {
            throw new System.NotImplementedException();
        }

        public Employee ReadEmployee(string id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Employee> ListEmployee()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateEmployee(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}