using Administration_RRHH.Service.Persistencia;
using Administration_RRHH.UI.Catalogs;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Models
{
    public class Employee : Individual
    {
        #region Properties
        public Municipality Municipality_Id { get; set; }
        public MaritalStatus MaritalStatus_Id { get; set; }
        public string Inss { get; set; } //Número de seguro social
                                        
        public string Email { get; set; }
        public int NumberChildren { get; set; }

        public bool isEnabled { get; set; }

        #endregion

        #region Constructs
        public Employee() : base()
        {
            Municipality_Id = new Municipality();
            MaritalStatus_Id = new MaritalStatus();
            Inss = string.Empty;
            Email = string.Empty;
            NumberChildren = 0;
            isEnabled = true;
        }

        public Employee(string idNumber, string name, string surname, DateOnly birthDate,
            string phone, string address, Municipality municipality_Id,
            MaritalStatus maritalStatus_Id, string inss, string email,
            int numberChildren, bool isEnabled) : base(idNumber, name, surname,
            birthDate, phone, address)
        {
            this.Municipality_Id = municipality_Id;
            this.MaritalStatus_Id = maritalStatus_Id;
            this.Inss = inss;
            this.Email = email;
            this.NumberChildren = numberChildren;
            this.isEnabled = isEnabled;
        }
        #endregion

        #region Methods
        public override bool ValidateBirthDate()
        {
            //Validar que la fecha de nacimiento sea una fecha valida.
            if (BirthDate > DateOnly.FromDateTime(DateTime.Today))
            {
                return false;
            }
            return true;
        }//end method

        public int InsertEmployee ()
        {
            int rows = 0; //Variable para almacenar el número de filas afectadas por la operación de inserción

            try
            {
                // Crear una instancia de InsertCommand para ejecutar la consulta de inserción
                using InsertCommand insert = new InsertCommand();

                //Definir la consulta SQL para insertar un nuevo empleado en la base de datos
                string sql = @"INSERT INTO Employees (IdNumber, Name, Surname, BirthDate, Phone, Address, Municipality_Id, 
                               MaritalStatus_Id, Inss, Email, NumberChildren, isEnabled)
                               VALUES (@IdNumber, @Name, @Surname, @BirthDate, @Phone, @Address, @Municipality_Id, 
                               @MaritalStatus_Id, @Inss, @Email, @NumberChildren, @isEnabled)";

                //Definir los parametros para la consulta SQL utilizando las propiedades del objeto Employee
                SqlParameter[] parameters =
                    {
                        new SqlParameter ("@Municipality_Id", SqlDbType.Int) { Value = Municipality_Id.Id },
                        new SqlParameter ("@MaritalStatus_Id", SqlDbType.Int) { Value = MaritalStatus_Id.Id },
                        new SqlParameter ("@Inss", SqlDbType.VarChar) { Value = Inss },
                        new SqlParameter ("@Email", SqlDbType.VarChar) { Value = Email },
                        new SqlParameter ("@NumberChildren", SqlDbType.Int) { Value = NumberChildren },
                        new SqlParameter ("@isEnabled", SqlDbType.Bit) { Value = isEnabled }
                    };
                //Ejecutar la consulta de inserción utilizando el método ExecuteInsert de la clase InsertCommand
                rows = insert.ExecuteInsert(sql, parameters);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el empleado: " + ex.Message);
            }

            //retornar las filas afectas
            return rows;
        }

        #endregion  

    }//end class
}//end namespace