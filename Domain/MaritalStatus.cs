using Administration_RRHH.Services.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Domain
{
    public class MaritalStatus
    {
        #region Properties
        public short MaritalStatusId { get; set; }
        public string MaritalStatusCode { get; set; }
        public string DescriptionStatus { get; set; }
        public bool Enable { get; set; }

        #endregion

        #region Constructors
        public MaritalStatus()
        {
            MaritalStatusId = 0;
            MaritalStatusCode = string.Empty;
            DescriptionStatus = string.Empty;
            Enable = true;
        }

        public MaritalStatus(string maritalStatusCode, string descriptionStatus, bool enable = true)
        {
            MaritalStatusCode = maritalStatusCode;
            DescriptionStatus = descriptionStatus;
            Enable = enable;
        }

        #endregion

        #region Methods
        public bool ExistsByCode(string maritalStatusCode)
        {
            const string sql = @"SELECT CASE
                                    WHEN EXISTS(
                                        SELECT 1
                                        FROM MaritalStatus
                                        WHERE MaritalStatusCode = @MaritalStatusCode)
                                    THEN 1 ELSE 0 END";

            using SelectQuery select = new();

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaritalStatusCode", SqlDbType.VarChar, 16) { Value = maritalStatusCode }
            };

            return select.IsDuplicate(sql, parameters);
        }

        public int AddMaritalStatus()
        {
            const string sql = @"INSERT INTO MaritalStatus
                                    (MaritalStatusCode, DescriptionStatus, Enable)
                                VALUES
                                    (@MaritalStatusCode, @DescriptionStatus, @Enable)";

            try
            {
                using InsertCommand insert = new();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaritalStatusCode", SqlDbType.VarChar, 16) { Value = MaritalStatusCode },
                    new SqlParameter("@DescriptionStatus", SqlDbType.VarChar, 32) { Value = DescriptionStatus },
                    new SqlParameter("@Enable", SqlDbType.Bit) { Value = Enable }
                };

                return insert.ExecuteInsert(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el estado civil.", ex);
            }
        }

        public MaritalStatus? GetMaritalStatusById(short maritalStatusId)
        {
            const string sql = @"SELECT MaritalStatus_id,
                                        MaritalStatusCode,
                                        DescriptionStatus,
                                        Enable
                                FROM MaritalStatus
                                WHERE MaritalStatus_id = @MaritalStatusId";

            try
            {
                using SelectQuery select = new();

                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaritalStatusId", SqlDbType.SmallInt) { Value = maritalStatusId }
                };

                using SqlDataReader reader = select.ExecuteSelect(sql, parameters);

                if (!reader.Read())
                    return null;

                return MapFromReader(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el estado civil.", ex);
            }
        }

        public List<MaritalStatus> ListMaritalStatus()
        {
            const string sql = @"SELECT MaritalStatus_id,
                                        MaritalStatusCode,
                                        DescriptionStatus,
                                        Enable                                
                                FROM MaritalStatus WHERE Enable = 1";

            try
            {
                using SelectQuery select = new();
                using SqlDataReader reader = select.ExecuteSelect(sql);

                List<MaritalStatus> maritalStatuses = new();
                // Recorremos el DataReader y mapeamos cada registro a una instancia de MaritalStatus
                while (reader.Read())
                    maritalStatuses.Add(MapFromReader(reader));

                return maritalStatuses;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los estados civiles.", ex);
            }
        }

        /// <summary>
        /// Mapea un registro de la base de datos a una instancia de MaritalStatus.
        /// </summary>
        /// <param name="reader">DataReader con los datos del registro</param>
        /// <returns>Instancia de MaritalStatus</returns>
        private static MaritalStatus MapFromReader(SqlDataReader reader)
        {
            return new MaritalStatus
            {
                MaritalStatusId = reader.GetInt16(reader.GetOrdinal("MaritalStatus_id")),
                MaritalStatusCode = reader.GetString(reader.GetOrdinal("MaritalStatusCode")),
                DescriptionStatus = reader.GetString(reader.GetOrdinal("DescriptionStatus")),
                Enable = reader.GetBoolean(reader.GetOrdinal("Enable"))
            };
        }

        #endregion

    }//end-class
}//end-namespace
