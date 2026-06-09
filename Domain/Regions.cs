using Administration_RRHH.Services.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Domain
{
    public class Regions
    {
        #region Propiedades
        // -- --------------------------------------------------------------------------------------- -- */
        //                          Declaración de propiedades de la clase Region
        // -- --------------------------------------------------------------------------------------- -- */
        public int Region_Id { get; set; } //Manipulado directamente por la base de datos, no se asigna manualmente.
        public string RegionCode { get; set; }
        public string Description { get; set; } //Nombre de la región
        public bool Enabled { get; set; } //Indica si la región está activa o no

        #endregion

        #region Constructores
        // -- --------------------------------------------------------------------------------------- -- */
        //                          Declaración de Constructores de la clase Region
        // -- --------------------------------------------------------------------------------------- -- */
        public Regions () 
        {
            RegionCode = string.Empty;
            Description = string.Empty;
            Enabled = true;
        }

        // Constructor con parámetros para facilitar la creación de objetos Region con datos específicos.
        public Regions(string regionCode, string description, bool enabled)
        {
            RegionCode = regionCode;
            Description = description;
            Enabled = enabled;
        }

        #endregion

        #region
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
            int rows = 0;

            try
            {
                using InsertCommand insert = new InsertCommand(); //Crear instancia de comando de
                                                                  //inserción para ejecutar la consulta SQL
                string sql = @"INSERT INTO Region (DepartmentCode, Description) 
                          VALUES (@DptCode, @Description)";

                SqlParameter[] parametros = {
                                            new SqlParameter("@DptCode", SqlDbType.VarChar, 16) { Value = this.RegionCode },
                                            new SqlParameter("@Description", SqlDbType.VarChar, 32) { Value = this.Description }
                                            };
                rows = insert.ExecuteInsert(sql, parametros); //Ejecutar la consulta de inserción y retornar el número de filas afectadas
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar agregar un Departamento: " + ex.Message);
            }

            return rows;
        }

        public Regions? GetRegionById(int id)
        {
            // Lógica para obtener una región específica por su ID desde la base de datos
            string sql = @"SELECT RegionId,
                            DepartmentCode,
                            Description,
                            enabled
                           FROM Region
                           WHERE RegionId = @RegionId";

            try
            {
                using SelectQuery select = new();

                SqlParameter[] parametros =
                                        {
                                            new SqlParameter("@RegionId", SqlDbType.Int) { Value = id}
                                        };

                //Obtener el resultaado de la consulta
                using SqlDataReader result = select.ExecuteSelect(sql, parametros);

                //Validar si hubieron resultados de la consulta, si no se encuentra la región, retornar null
                if (!result.Read())
                    return null; // Si no se encuentra la región, retornar null

                return new Regions
                {
                    Region_Id = result.GetInt32(result.GetOrdinal("RegionId")),
                    RegionCode = result.GetString(result.GetOrdinal("DepartmentCode")),
                    Description = result.GetString(result.GetOrdinal("Description")),
                    Enabled = result.GetBoolean(result.GetOrdinal("Enabled"))
                };

            }
            catch (Exception ex)
            {
                throw new Exception( "Error al intentar obtener la región (Departamento).", ex);
            }//end-catch

        }

        public List<Regions> ListRegion ()
        {
            // Lógica para obtener una lista de regiones desde la base de datos
            string sql = @"SELECT * FROM Region";

            //Crear una instancia de la clase SelectQuery para aplicar la consulta
            using SelectQuery select = new SelectQuery();

            //Asignar los datos obtenidos para procesar en el retorno del método
            using SqlDataReader reader = select.ExecuteSelect(sql);

            // Verificar si result es null
            if (!reader.HasRows)
            {
                throw new Exception("No se han encontrado Departamentos Disponibles");
            }
             //Definir una lista para almacenar los datos encontrados y retornarla
            List<Regions> regionSelected = new List<Regions>();

            //Recorrer el objeto reader con los elementos recuperados
            while (reader.Read())
            {
                regionSelected.Add(new Regions 
                { 
                    Region_Id = reader.GetInt32(0),
                    RegionCode = reader.GetString(1),
                    Description = reader.GetString(2),
                    Enabled = reader.GetBoolean(3)
                });
            }//end while
            //Retornar la lista de regiones obtenida
            return regionSelected;
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
        #endregion
    }//end class
}//end namespace
