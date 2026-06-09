using Administration_RRHH.Services.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Domain
{
    public class Employee : Individual
    {

        #region Propiedades
        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Propiedades                            */
        /* -------------------------------------------------------------------------- */

        public Municipality Municipality_Id { get; set; }
        public MaritalStatus MaritalStatus_Id { get; set; }
        public string Inss { get; set; }
        public string Email { get; set; }
        public int NumberChildren { get; set; }
        public bool IsEnabled { get; set; }

        #endregion

        #region Constructores
        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Constructor                           */
        /* -------------------------------------------------------------------------- */
        public Employee() 
        {
            Municipality_Id = new Municipality(); //Inicializar con un objeto vacío para evitar referencias nulas
            MaritalStatus_Id = new MaritalStatus(); //Inicializar con un objeto vacío para evitar referencias nulas
            Inss = string.Empty;
            Email = string.Empty;
            NumberChildren = 0;
            IsEnabled = true;
        }

        public Employee(Municipality municipality_Id, MaritalStatus maritalStatus_Id, string inss, string email, bool isEnable, int numberChildren,
                        string idNumber, string name, string surname, DateOnly birthdate,
                        string phone, string address) :
                        base(idNumber, name, surname, birthdate, phone, address)
        {
            Municipality_Id = municipality_Id;
            MaritalStatus_Id = maritalStatus_Id;
            Inss = inss;
            Email = email;
            IsEnabled = isEnable;
            NumberChildren = numberChildren;
        }

        #endregion
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
                return true; // La fecha de nacimiento es inválida
            }
            return false; // La fecha de nacimiento no es válida
        }

        public bool ExistsByField(string fieldName, string fieldValue)
        {
            string columnName = fieldName switch
            {
                nameof(IdNumber) => "IdNumber",
                nameof(Inss) => "Inns",
                nameof(Email) => "Email",
                nameof(Phone) => "Phone",
                "Inns" => "Inns",
                _ => throw new ArgumentException("Campo no permitido para validar duplicados.", nameof(fieldName))
            };

            string sql = $@"SELECT CASE
                                WHEN EXISTS(
                                    SELECT 1
                                    FROM Employee
                                    WHERE {columnName} = @FieldValue)
                                THEN 1 ELSE 0 END";

            using SelectQuery select = new();

            SqlParameter[] parameters =
            {
                new SqlParameter("@FieldValue", SqlDbType.VarChar) { Value = fieldValue }
            };

            return select.IsDuplicate(sql, parameters);
        }

        public int InsertEmployee  ()
        {
            int rows = 0; // Variable para almacenar el número de filas afectadas por la inserción

            try
            {
                using InsertCommand insert = new InsertCommand(); //Crear instancia de comando de
                                                                  //inserción para ejecutar la consulta SQL
                string sql = @"INSERT INTO Employee (Municipality_id, MaritalStatus_id, IdNumber, Inns, Names, Surname,
                                                Birthdate, NumberChildren, Email, Phone, Address, Enable) 
                          VALUES (@Municipality_id, @MaritalStatus_id, @IdNumber, @Inss, @Names, @Surname,
                                                @Birthdate, @NumberChildren, @Email, @Phone, @Address, @Enable)";

                SqlParameter[] parametros = {
                                            new SqlParameter("@Municipality_id",   SqlDbType.Int) { Value = this.Municipality_Id.MunicipalityId },
                                            new SqlParameter("@MaritalStatus_id",   SqlDbType.SmallInt) { Value = this.MaritalStatus_Id.MaritalStatusId },
                                            new SqlParameter("@IdNumber", SqlDbType.VarChar,  24) { Value = this.IdNumber },
                                            new SqlParameter("@Inss", SqlDbType.VarChar,  16) { Value = this.Inss },
                                            new SqlParameter("@Names", SqlDbType.VarChar,  32) { Value = this.Name },
                                            new SqlParameter("@Surname", SqlDbType.VarChar,  32) { Value = this.Surname },
                                            new SqlParameter("@Birthdate", SqlDbType.Date) { Value = this.BirthDate },
                                            new SqlParameter("@NumberChildren", SqlDbType.SmallInt) { Value = this.NumberChildren },
                                            new SqlParameter("@Email", SqlDbType.VarChar,  128) { Value = string.IsNullOrWhiteSpace(this.Email) ? DBNull.Value : this.Email },
                                            new SqlParameter("@Phone", SqlDbType.VarChar,  16) { Value = this.Phone },
                                            new SqlParameter("@Address", SqlDbType.VarChar,  512) { Value = string.IsNullOrWhiteSpace(this.Address) ? DBNull.Value : this.Address },
                                            new SqlParameter("@Enable", SqlDbType.Bit) { Value = this.IsEnabled }
                                            };
                //Ejecutar la consulta de inserción y almacenar el número de filas afectadas
                rows = insert.ExecuteInsert(sql, parametros);
            }

            catch (Exception ex)
            {
                throw new Exception("Se ha producido un error: " + ex.Message);
            }
            return rows;
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

        
        public List <Employee> ReadEmployee ()
        {
            // Lógica para obtener una lista de Empleados desde la base de datos
            string sql = @"SELECT	
                            E.IdNumber,
		                    E.Inns,
		                    E.Names,
		                    E.Surname,			
		                    E.Phone,
		                    E.Email
		                    FROM Employee AS E
                            WHERE E.Enable = 1";

            //Crear una instancia de la clase SelectQuery para aplicar la consulta
            using SelectQuery select = new SelectQuery();

            //Asignar los datos obtenidos para procesar en el retorno del método
            using SqlDataReader reader = select.ExecuteSelect(sql);

            // Verificar si result es null
            if (!reader.HasRows)
            {
                throw new Exception("No se han encontrado Empleados Disponibles");
            }
            //Definir una lista para almacenar los datos encontrados y retornarla
            List<Employee> employeeSelected = new List<Employee>();

            //Recorrer el objeto reader con los elementos recuperados
            while (reader.Read())
            {
                employeeSelected.Add(new Employee
                {
                    IdNumber = reader.GetString(0),
                    Inss = reader.GetString(1),
                    Name = reader.GetString(2),
                    Surname = reader.GetString(3),
                    Email = reader.GetString(4),
                    Phone = reader.GetString(5),
                    Address = reader.GetString(6)                    
                });
            }//end while
            //Retornar la lista de empleados obtenida
            return employeeSelected;
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
