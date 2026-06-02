using Administration_RRHH.Services.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Domain
{
    public class Region
    {
        #region Propiedades
        // -- --------------------------------------------------------------------------------------- -- */
        //                          Declaración de propiedades de la clase Region
        // -- --------------------------------------------------------------------------------------- -- */
        public int RegionId { get; set; } //Manipulado directamente por la base de datos, no se asigna manualmente.
        public string RegionCode { get; set; }
        public string Description { get; set; } //Nombre de la región
        public bool Enabled { get; set; } //Indica si la región está activa o no

        #endregion

        #region Constructores
        // -- --------------------------------------------------------------------------------------- -- */
        //                          Declaración de Constructores de la clase Region
        // -- --------------------------------------------------------------------------------------- -- */
        public Region () 
        {
            RegionCode = string.Empty;
            Description = string.Empty;
            Enabled = true;
        }

        // Constructor con parámetros para facilitar la creación de objetos Region con datos específicos.
        public Region(string regionCode, string description, bool enabled)
        {
            RegionCode = regionCode;
            Description = description;
            Enabled = enabled;
        }

        #endregion

        // -- --------------------------------------------------------------------------------------- -- */
        //                          Metodos adicionales (si es necesario) para la clase Region
        // -- --------------------------------------------------------------------------------------- -- */

        public bool isUniqueRegionCode(string dptCode)
        {
            // Lógica para verificar si el código de región es único en la base de datos
            string sql = @"SELECT CASE
                                  WHEN EXISTS(
                                       SELECT 1
                                       FROM Region 
                                       WHERE DepartmentCode = @DptCode)
                                       THEN 1 ELSE 0 END";

            using SelectQuery select = new SelectQuery(); // Crear instancia de SelectQuery
                                                          // para ejecutar la consulta SQL
            SqlParameter[] parametros = {
                                            new SqlParameter("@DptCode", SqlDbType.VarChar, 16) { Value = dptCode }
            }; 
            return select.IsDuplicate(sql, parametros);
        }

        /// <summary>
        /// Agrega una nueva región a la base de datos utilizando el comando de inserción.
        /// </summary>
        /// <returns>Número de filas afectadas</returns>

        public int AddRegion()
        {

            using InsertCommand insert = new InsertCommand(); //Crear instancia de comando de
                                                              //inserción para ejecutar la consulta SQL
            string sql = @"INSERT INTO Region (DepartmentCode, Description) 
                          VALUES (@DptCode, @Description)";

            SqlParameter[] parametros = {
                                            new SqlParameter("@DptCode", SqlDbType.VarChar, 16) { Value = this.RegionCode },
                                            new SqlParameter("@Description", SqlDbType.VarChar, 32) { Value = this.Description }
            };

            return insert.ExecuteInsert(sql, parametros); //Ejecutar la consulta de inserción y retornar el número de filas afectadas

        }

        public Region GetRegionByCode(int filter)
        {
            // Lógica para obtener una región específica por su ID desde la base de datos
            return new Region(); // Placeholder, se implementará la lógica real posteriormente
        }


        public List<Region> ListRegion ()
        {
            // Lógica para obtener una lista de regiones desde la base de datos
            return new List<Region>(); // Placeholder, se implementará la lógica real posteriormente
        }


        public void ModificRegion(string code)
        {
            // Lógica para actualizar la información de la región en la base de datos
        }

        public bool  InhabilityRegion ()
        {
            // Lógica para eliminar o deshabilitar la región en la base de datos
            return true; // Placeholder, se implementará la lógica real posteriormente
        } 

    }//end class
}//end namespace
