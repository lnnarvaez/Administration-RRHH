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
            get => _address;
            set
            {
                _address = value;
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
            get => _email;
            set
            {
            }
        }

        public string IdentityCard
        {
            get => _email;
            set
            {
            }
        }

        public string MaritalStatus
        {
            get => _email;
            set
            {
            }
        }

        public string Name
        {
            get => _email;
            set
            {
            }
        }

        public string Phone
        {
            get => _email;
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
            var lst = new List<Employee>();

            lst.Add(this);  // Agrega el empleado actual a la lista

            if (lst.Count > 0)
                return true; // Retorna true si se agregó el empleado a la lista

            return false;   // Retorna false si no se agregó el empleado a la lista
        }//End AddEmployee

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