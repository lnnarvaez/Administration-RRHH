using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 
using System.Text.Json;

namespace Administration_RRHH.Domain
{
    public class Employee : Individual
    {

        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Propiedades                            */
        /* -------------------------------------------------------------------------- */

        public string Inss { get; set; }
        public string Email { get; set; }
        public int NumberChildren { get; set; }
        public bool IsActive { get; set; }
        

        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Constructor                           */
        /* -------------------------------------------------------------------------- */
        public Employee() { }

        public Employee(string inss, string email, bool isActive, int numberChildren,
                        string idNumber, string name, string surname, DateOnly birthdate,
                        string phone, string address) :
                        base(idNumber, name, surname, birthdate, phone, address)
        {
            Inss = inss;
            Email = email;
            IsActive = isActive;
            NumberChildren = numberChildren;
        }

        /* -------------------------------------------------------------------------- */
        /*                           Declaración de Método                            */
        /* -------------------------------------------------------------------------- */

        /// <summary>
        /// Valida que la fecha de nacimiento del empleado no sea una fecha futura.
        /// </summary>
        /// <returns>Verdadero si la fecha es válida, falso en caso contrario</returns>
        public override bool ValidateBirthDate()
        {
            // Validar que la fecha de nacimiento no sea una fecha futura
            if (BirthDate > DateOnly.FromDateTime(DateTime.Today))
            {
                return false; // La fecha de nacimiento es inválida
            }
            return true; // La fecha de nacimiento es válida
        }

        public int AddEmployee  ()
        {
            return 0; //Pendiente de implementación con la base de datos
        }

        /// <summary>
        /// Lee el registro de un empleado especificado por su número de cédula
        /// </summary>
        /// <param name="idNumber">Número de cédula para filtrar al empleado</param>
        /// <returns>Empleado identificado por cédula. Null sino se encuentra</returns>
        public Employee GetEmployeeIdNumber (int idNumber)
        {
            return new Employee(); //Temporal mientras se defien BD
        }

        /// <summary>
        /// Lista un set de Empleados, segmentados por bloques de páginación 10 en 10
        /// </summary>
        /// <returns>Listado de Empleados ordenados de forma descendente por fecha de ingreso</returns>
        public List <Employee> ListEmployee ()
        { 
            return new List<Employee>(); // Pendiente de implementación con la base de datos
        }

        /// <summary>
        /// Modifica el registro de un empleado especificado por su número de cédula. 
        /// El método recibe el número de cédula del empleado a modificar y los nuevos 
        /// datos del empleado.
        /// </summary>
        /// <param name="idNumber"></param>
        public void ModifyEmployee (string idNumber)
        {
            // Pendiente de implementación con la base de datos
        }

        /// <summary>
        /// Deshabilita el registro de un empleado especificado por su número de cédula.
        /// </summary>
        /// <param name="idNumber"></param>
        public void DisableEmployee(string idNumber)
        {
            // Pendiente de implementación con la base de datos
        }   


    }//end-class
}//end-namespace