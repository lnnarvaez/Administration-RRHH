using Administration_RRHH.Domain;

namespace Administration_RRHH.Services.BusinessLogic
{
    internal class EmployeeBusiness
    {
        private readonly Employee _employee; //Instancia de la clase Employee para realizar
                                             //operaciones relacionadas con los empleados
        #region Constructores
        public EmployeeBusiness ()
        {
            _employee = new Employee ();
        }

        public EmployeeBusiness(Employee employee)
        {
            _employee = employee;
        }
        #endregion

        #region Métodos
        public int AddEmployee()
        {
            try
            {
                //Validar que los campos que deben ser únicos no se encuentren duplicados en el sistema
                UniqueFieldsEmployee();

                //Si los campos no estan duplicados se aplica la inserción
                return _employee.InsertEmployee();
            }
            catch (Exception ex)
            {
                throw new Exception("Posibilidad de campos duplicados.", ex);
            }
        }

        public List<Employee> ListEmployees()
        {
            try
            {
                return _employee.ReadEmployee(); 
            }
            catch (Exception ex)
            {
                throw new Exception("No fue posible cargar los registros de Empleados.", ex);
            } //end try-catch
        }

        public int UpdateEmployee(string idNumber)
        {
            //Validar que el número de identificación no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(idNumber))
                throw new ArgumentException("Número de cédula es requerido");
            //Continuar con la lógica de actualización
            return _employee.EmployeeUpdate(idNumber);
        }

        /// <summary>
        /// Procesar la baja del registro del empleado indicado por su número de identificación.
        /// </summary>
        /// <param name="idNumber">El número de identificación del empleado a eliminar.</param>
        /// <returns>El número de filas afectadas por la operación.</returns>
        /// <exception cref="ArgumentException">Lanzada cuando el número de identificación es nulo o vacío.</exception>
        public int DeleteEmployee(string idNumber)
        {
            if (string.IsNullOrWhiteSpace(idNumber))
                throw new ArgumentException("Se requiere indicar cédula del empleado para dar de baja.");
            //Se procesa la baja del empleado utilizando el método DisableEmployee
            return _employee.EmployeeDelete(idNumber);
        }

        private void UniqueFieldsEmployee()
        {
            //Validar que la cédula de un empleado no se encuentre duplicada en el sistema
            if (_employee.ExistsByField(nameof(Employee.IdNumber), _employee.IdNumber))
                throw new Exception($"El número de identificación '{_employee.IdNumber}' ya existe.");

            //Validar que el número INSS de un empleado no se encuentre duplicado en el sistema
            if (_employee.ExistsByField(nameof(Employee.Inss), _employee.Inss))
                throw new Exception($"El número INSS '{_employee.Inss}' ya existe.");

            //Validar que el correo electrónico de un empleado no se encuentre duplicado en el sistema
            if (!string.IsNullOrWhiteSpace(_employee.Email)
                && _employee.ExistsByField(nameof(Employee.Email), _employee.Email))
                throw new Exception($"El correo electrónico '{_employee.Email}' ya existe.");

            //Validar que el número de teléfono de un empleado no se encuentre duplicado en el sistema
            if (_employee.ExistsByField(nameof(Employee.Phone), _employee.Phone))
                throw new Exception($"El teléfono '{_employee.Phone}' ya existe.");
        }

        #endregion
    } //end-class
} //end-namespace
