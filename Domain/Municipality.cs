using Administration_RRHH.Services.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Domain
{
    internal class Municipality
    {
       
        //Encapular atributo de navegación para la propiedad Region

        private Regions? _region;
        private int _regionId; // Guardamos el ID oculto, con el que se maneja en la base datos

        #region Properties
        /* -- ---------------------------------------------------------------- -- */
        /*      Definición de propiedades para la clase MunicipalityModels.       */
        /* -- ---------------------------------------------------------------- -- */
        public int MunicipalityId { get; set; }
        public required string MunicipalityCode { get; set; }
        public required string MunicipalityName { get; set; }
        public bool IsEnable { get; set; }

        //Establecer la propiedad de navegación para la región asociada a este municipio.
        public Regions RegionId
        {
            get
            {
                //cuando se pide la propiedad y no se ha cargado de la base de datos, se carga automáticamente
                if (_region == null && _regionId > 0)
                {
                    Regions? regions = _region.GetRegionById(_regionId); //Obtener la región asociada a este municipio.
                }
                return _region;
            }//end-get

            set
            {
                _region = value;
                if (value != null)
                {
                    _regionId = value.Region_Id;
                }
            }
        }//end-Region

        #endregion

        #region Constructors
        /* -- ---------------------------------------------------------------- -- */
        /*      Constructor de la clase Municipality              */
        /* -- ---------------------------------------------------------------- -- */

        public Municipality () 
        { 
            MunicipalityId = 0;
            MunicipalityCode = string.Empty;
            MunicipalityName = string.Empty;
            IsEnable = true;
        }

        //Constructor para mapear con la base de datos
        public Municipality(int RegionId)
        {
            _regionId = RegionId;
        }

        public Municipality(int municipalityId, string municipalityCode,
            string municipalityName, bool isEnable)
        {
            MunicipalityId = municipalityId;
            MunicipalityCode = municipalityCode;
            MunicipalityName = municipalityName;
            IsEnable = isEnable;
        } //Constructor con parámetros para la clase MunicipalityModels.

        #endregion

        #region Methods
        /* -- ---------------------------------------------------------------- -- */
        /*              Métodos de operación en la base de datos.                 */
        /* -- ---------------------------------------------------------------- -- */

        public bool isUniqueMunicipalityCode(string municipalityCode)
        {
            // Lógica para verificar si el código de municipio es único en la base de datos
            string sql = @"SELECT CASE
                                   WHEN EXISTS(
                                        SELECT 1
                                        FROM Municipality 
                                        WHERE MunicipalityCode = @MunicipalityCode)
                                        THEN 1 ELSE 0 END";
            using SelectQuery select = new SelectQuery(); // Crear instancia de SelectQuery
                                                          // para ejecutar la consulta SQL
            SqlParameter[] parametros = {
                                             new SqlParameter("@MunicipalityCode", SqlDbType.VarChar, 16) { Value = municipalityCode }
            };
            //Consultar en la base de datos si ya existe el código del municipio
            return select.IsDuplicate(sql, parametros);
        }
        public int InsertMunicipality()
        {
            int rows = 0;
            // Lógica para agregar la región a la base de datos            
            try
            {
                // 1. Instanciar la subclase InsertCommand con 'using' — garantiza Dispose() automático
                using InsertCommand insert = new InsertCommand();

                // 2. Escribir el SQL parametrizado
                string sql = @"INSERT INTO Municipality (Region_id,MunicipalityCode, MunicipalityName, Enable)
                               VALUES (@RegionId, @MunicipalityCode, @MunicipalityName, @IsEnable)";

                // 3. Declarar los parámetros con su tipo exacto de SQL Server
                SqlParameter[] parameters =
                                {
                                    new SqlParameter("@RegionId", SqlDbType.Int) { Value = this.RegionId.Region_Id },
                                    new SqlParameter("@MunicipalityCode", SqlDbType.VarChar, 16) { Value = this.MunicipalityCode },
                                    new SqlParameter("@MunicipalityName", SqlDbType.VarChar, 32) { Value = this.MunicipalityName },
                                    new SqlParameter("@IsEnable", SqlDbType.Bit) { Value = this.IsEnable }
                                };

                // 4. Usar ExecuteInsert si solo se necesita saber si insertó
                rows = insert.ExecuteInsert(sql, parameters);
            }
            catch (Exception ex)
            {
                //Lanzar una excepción o manejar el error según la política de la aplicación
                throw new Exception("Error al agregar el municipio.", ex); // Re-lanzar la excepción para que sea manejada por el llamador
            }

            return rows; // Retorna el número de filas afectadas por la inserción, cero si no se insertó nada
        }

        #endregion
    }//end class
} //end namespace
