namespace Administration_RRHH.Domain
{
    public class FamilyReference : Individual
    {
        public long FamilyReferencesId { get; set; }
        public long EmployeeFileId { get; set; }
        public string BiologicalSex { get; set; }
        public string Relationship { get; set; }

        //Invocar al constructor sin parámetros para inicializar las propiedades
        public FamilyReference()
        {
            FamilyReferencesId = 0; //Campo ID manejado por el SGBD, se inicializa en 0
            EmployeeFileId = 0; //Campo ID manejado por el SGBD, se inicializa en 0
            BiologicalSex = string.Empty;
            Relationship = string.Empty;
        }

        public FamilyReference(long familyReferencesId, long employeeFileId, string biologicalSex, 
            string relationship,
                               string idNumber, string name, string surname, DateTime birthdate,
                               string phone, string address) : 
                               base(idNumber, name, surname, birthdate, phone, address)
        {
            FamilyReferencesId = familyReferencesId;
            EmployeeFileId = employeeFileId;
            BiologicalSex = biologicalSex;
            Relationship = relationship;
        }
        /// <summary>
        /// Calcula la edad del familiar basándose en su fecha de nacimiento.
        /// </summary>
        /// <returns>La edad del familiar.</returns>
        /// <exception cref="ArgumentException">Se lanza cuando la fecha de nacimiento es futura.</exception>
        protected override int CalculateAge()
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
    } //end-class
}//end-namespace
