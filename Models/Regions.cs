using Administration_RRHH.Service.Persistencia;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Models
{
    internal class Regions
    {
        #region Propperties
        public int RegionId { get; set; }
        public string RegionCode { get; set; } = string.Empty;
        public string RegionName { get; set; } = string.Empty;
        public bool isEnabled { get; set; }
        #endregion

        #region
        public Regions() 
        {
            RegionId = 0; //Controlado por la base de datos
            RegionCode = string.Empty;
            RegionName = string.Empty;
            isEnabled = true; //El objeto será utiñlizado, su disponibilidad es true
        }

        public Regions(int regionId, string regionCode, string regionName, 
            bool isEnabled)
        {
            RegionId = regionId;
            RegionCode = regionCode;
            RegionName = regionName;
            this.isEnabled = isEnabled;
        }
        #endregion

        #region Methods
        public int addRegion()
        {
            int rows = 0; //Indica la cantidad de registros afectados por la consulta

            //1.Lógica para agregar un nuevo departamento (Region) a la base de datos
            try
            {
                //2. Instanciar la clase InsertCommand con using
                using InsertCommand insert = new InsertCommand();

                //3. Escribir la consulta SQL para insertar un nuevo departamento (Region)
                string sql = @"INSERT INTO Regions (RegionCode, RegionName) 
                            VALUES (@RegionCode, @RegionName)";
                //4. Declarar los parametros para la consulta SQL
                SqlParameter[] parameters =
                    {
                        new SqlParameter ("@RegionCode", SqlDbType.VarChar, 16) { Value = this.RegionCode},
                        new SqlParameter ("@RegionName", SqlDbType.VarChar, 32) { Value = this.RegionName}
                    };

                //5. Procesar la consulta SQL utilizando el método ExecuteInsert de la clase InsertCommand
                rows = insert.ExecuteInsert(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar agregar Departamento.", ex);
            }
            return rows;
        }
        #endregion
    } //end class
} //end namespace
