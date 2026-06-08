using Administration_RRHH.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Services.BusinessLogic
{
    internal class EmployeeBusiness
    {
        Employee employee; //Instancia de la clase Employee para realizar
                           //operaciones relacionadas con los empleados

        public EmployeeBusiness ()
        {
            employee = new Employee ();
        }

        public int InsertEmployee()
        {
           /* // VALIDACIÓN DE NEGOCIO (Seguridad e Integridad)
            // Supongamos que "ValidarCorreoUnico" busca en la base de datos
            if (ValidarCorreoUnico(cliente.Correo) == false)
            {
                throw new Exception("El correo electrónico ya se encuentra registrado por otro cliente.");
            }

            // Si pasa la regla, se envía a guardar en la base de datos
            ClienteDAL datos = new ClienteDAL();
            datos.Insertar(cliente);
           */


            return 0; 
        }

        public Employee ReadEmployee(string idNumber)
        {
            return new Employee(); //Pendiente de implementación con la base de datos
        }       

        public List<Employee> ListEmployees(int pageNumber)
        {
            return new List<Employee>(); //Pendiente de implementación con la base de datos
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
