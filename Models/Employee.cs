namespace Administration_RRHH.Models
{
    public class Employee
    {
        /* ---------------------------------------------------------------- */
        /*     Campos o Atributos de la Clase                               */
        /* -----------------------------------------------------------------*/
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

        /* ---------------------------------------------------------------- */
        /*     Constructor para nuevas instancias                           */
        /* -----------------------------------------------------------------*/
        public Employee()
        {
            //Definir el estado valido del objeto, por ejemplo:
            this._identityCard = string.Empty;
            this._name = string.Empty;
            this._surname = string.Empty;
            this._birthDate = DateOnly.FromDateTime(System.DateTime.Now);//Tomar la fecha actual como valor por defecto
            this._maritalStatus = string.Empty;
            this._numberChildren = 0;
            this._email = string.Empty;
            this._phone = string.Empty;
            this._address = string.Empty;
        }

        //Definir un constructor con parámetros para facilitar la creación de objetos Employee, por ejemplo:
        public Employee(string name, string surname, string identityCard, string address, 
            System.DateOnly birthDate, string maritalStatus, 
            int numberChildren, string email, string phone, bool status)
        {
            _name = name;
            _surname = surname;
            _identityCard = identityCard;
            _address = address;
            _birthDate = birthDate;
            _maritalStatus = maritalStatus;
            _numberChildren = numberChildren;
            _email = email;
            _phone = phone;
            _status = status;
        }

        /* ---------------------------------------------------------------- */
        /*     Propiedades para instancias de Employee                     */
        /* -----------------------------------------------------------------*/
        public string Address
        {
            get => _address;
            set
            {
                //Validar el valor de la dirección, por ejemplo:
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("La dirección no puede estar vacía.");
                }//End if
                _address = value; //Asignar el valor a la variable de instancia
            }
        }

        public System.DateOnly BirthDate
        {
            get => _birthDate;
            set
            {
            }
        }

        public string Email
        {
            get => Email;
            set
            {
                //Validar el formato del correo electrónico, por ejemplo:
                if (!value.Contains("@"))
                {
                    throw new System.ArgumentException("El correo electrónico no es válido.");
                }//End if
                _email = value; 
            }
        }

        public string IdentityCard
        {
            get => _identityCard;
            set
            {
            }
        }

        public string MaritalStatus
        {
            get => _maritalStatus;
            set
            {
            }
        }

        public string Name
        {
            get => _name;
            set
            {
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
            }
        }

        public string Surname
        {
            get => _surname;
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
            //Implementar la lógica para agregar un nuevo empleado a la base de datos o a una colección, por ejemplo:
            var newEmployee = new List<Employee>(); //Crear una nueva lista de empleados
            newEmployee.Add(this);

            if (newEmployee.Count > 0)
            
                {
                    return true; //Empleado agregado exitosamente
                }//End if

                return false;   //No se pudo agregar el empleado
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