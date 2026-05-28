using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 
using System.Text.Json;

namespace Administration_RRHH.Domain
{
    public class Employee: Individual
    {
        //Declaración de propiedades propias
        public long EmployeeId { get; set; }
        public string Inns { get; set; }
        public short NumberChildren { get; set; }
        public string Email { get; set; }

        //Constructor para la clase Employee sin parámetros
        public Employee()
        {
            EmployeeId = 0; //Campo ID manejado por el SGBD, se inicializa en 0
            Inns = string.Empty;
            NumberChildren = 0;
            Email = string.Empty;
        }

        //Constructor para la clase Employee con parámetros
        public Employee(long employeeId, string inns, short numberChildren, string email,
                        string idNumber, string name, string surname, DateTime birthdate, 
                        string phone, string address) : 
                        base(idNumber, name, surname, birthdate, phone, address)
        {
            EmployeeId = employeeId;
            Inns = inns;
            NumberChildren = numberChildren;
            Email = email;
        }

        /// <summary>
        /// Calcula la edad del empleado basándose en su fecha de nacimiento.
        /// </summary>
        /// <returns>La edad del empleado.</returns>
        /// <exception cref="ArgumentException">Se lanza cuando la fecha de nacimiento es futura.</exception>
        protected override int CalculateAge ()
        {
            if (!ValidateBirthdate(Birthdate))
            {
                throw new ArgumentException("La fecha de nacimiento no puede ser futura.");
            }
            var today = DateTime.Today;
            var age = today.Year - Birthdate.Year;
            if (Birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }


    }//end-class
}//end-namespace