using Administration_RRHH.Domain;

namespace Administration_RRHH.Services.BusinessLogic
{
    internal class EmployeeBusiness
    {
        private readonly Employee _employee; //Instancia de la clase Employee para realizar
                                             //operaciones relacionadas con los empleados

        public EmployeeBusiness ()
        {
            _employee = new Employee ();
        }

        public EmployeeBusiness(Employee employee)
        {
            _employee = employee;
        }

        public int AddEmployee()
        {
            if (_employee.ExistsByField(nameof(Employee.IdNumber), _employee.IdNumber))
                throw new Exception($"El número de identificación '{_employee.IdNumber}' ya existe.");

            if (_employee.ExistsByField(nameof(Employee.Inss), _employee.Inss))
                throw new Exception($"El número INSS '{_employee.Inss}' ya existe.");

            if (!string.IsNullOrWhiteSpace(_employee.Email)
                && _employee.ExistsByField(nameof(Employee.Email), _employee.Email))
                throw new Exception($"El correo electrónico '{_employee.Email}' ya existe.");

            if (_employee.ExistsByField(nameof(Employee.Phone), _employee.Phone))
                throw new Exception($"El teléfono '{_employee.Phone}' ya existe.");

            return _employee.InsertEmployee(); //Retorna el número de filas afectadas por la inserción
        }

        public List<Employee> ListEmployees()
        {
            try
            {
                return _employee.ReadEmployee(); //Pendiente de implementación con la base de datos
            }
            catch (Exception ex)
            {
                throw new Exception("Intento fallido al leer Empleados.", ex);
            } //end try-catch
        }

        public int UpdateEmployee(string idNumber)
        {
            return 0;
        }

        public int DeleteEmployee(string idNumber)
        {
            return 0;
        } 

    } //end-class
} //end-namespace
