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
                               string idNumber, string name, string surname, DateOnly birthdate,
                               string phone, string address) : 
                               base(idNumber, name, surname, birthdate, phone, address)
        {
            FamilyReferencesId = familyReferencesId;
            EmployeeFileId = employeeFileId;
            BiologicalSex = biologicalSex;
            Relationship = relationship;
        }

        public override bool ValidateBirthDate()
        {
            throw new NotImplementedException();
        }
    } //end-class
}//end-namespace
