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
            this._birthDate = new System.DateOnly();
            this._maritalStatus = string.Empty;
            this._numberChildren = 18;
            this._email = string.Empty;
            this._phone = string.Empty;
            this._address = string.Empty;
        }

        /* ---------------------------------------------------------------- */
        /*     Propiedades para instancias de Employee                     */
        /* -----------------------------------------------------------------*/
        public string Address
        {
            get => default;
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

        /// <summary>
        /// Agrega una nueva instancia de Employee a la base de datos o colección correspondiente.
        /// </summary>
        /// <returns>true si la operación fue exitosa, o false en caso contrario</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool AddEmployee()
        {
            // Implementar la lógica para agregar un nuevo empleado, por ejemplo:
             if (string.IsNullOrEmpty(IdentityCard))
                return false;

             MessageBox.Show($"Empleado {Name} {Surname} agregado exitosamente.");

            return true; // Retornar true si la operación fue exitosa, o false en caso contrario
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