using System.Security.Permissions;

namespace Administration_RRHH.Domain
{
    public abstract class Individual
    {
        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Propiedades                            */
        /* -------------------------------------------------------------------------- */
        public string IdNumber { get; set; } //Número de cédula
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        
        /* -------------------------------------------------------------------------- */
        /*                      Constructor                                           */
        /* -------------------------------------------------------------------------- */
        public Individual()
        {
            IdNumber = string.Empty;
            Name = string.Empty;
            Surname = string.Empty;
            BirthDate = DateOnly.MinValue;
            Phone = string.Empty;
            Address = string.Empty;
        }
         
        //Constructor para crear un individuo con todos sus atributos
        public Individual (string idNumber, string name, string surname,
           DateOnly birthDate, string phone, string address)
        {
            this.IdNumber = idNumber;
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
            this.Phone = phone;
            this.Address = address;
        }

        /* -------------------------------------------------------------------------- */
        /*                               Método                                */
        /* -------------------------------------------------------------------------- */

        /// <summary>
        /// Calcula la edad del individuo en base a su fecha de nacimiento. Este método toma la fecha actual y 
        /// la fecha de nacimiento del individuo para determinar su edad actual. 
        /// Si el cumpleaños del individuo aún no ha ocurrido este año, se resta un año de la edad calculada.
        /// </summary>
        /// <returns>Edad actual calculada del Invididuo</returns>
        public int CalculateAge()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        // Método abstracto para validar la fecha de nacimiento, se implementará en las clases derivadas
        public abstract bool ValidateBirthDate(); 


    }//end-Class
}//end-namespace
