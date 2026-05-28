namespace Administration_RRHH.Domain
{
    public abstract class Individual
    {
        //Declaración de propiedades para la clase Individual
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        //Constructor para la clase Individual sin parámetros
        public Individual()
        {
            IdNumber = string.Empty;
            Name = string.Empty;
            Surname = string.Empty;
            Birthdate = DateTime.MinValue;
            Phone = string.Empty;
            Address = string.Empty;
        }

        //Constructor para la clase Individual con parámetros
        public Individual(string idNumber, string name, string surname, 
                          DateTime birthdate, string phone, string address)
        {
            IdNumber = idNumber;
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Phone = phone;
            Address = address;
        }

        //Método abstracto para calcular la edad de la persona
        protected abstract int CalculateAge();

        //Método para validar la fecha de nacimiento
        protected bool ValidateBirthdate(DateTime birthdate)
        {
            return birthdate <= DateTime.Now;
        }

    }//end-Class
}//end-namespace
