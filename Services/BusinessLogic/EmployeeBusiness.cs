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
           if (employee.AddEmployee() > 0)
            return 1; //Pendiente de implementación con la base de datos
           else
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
