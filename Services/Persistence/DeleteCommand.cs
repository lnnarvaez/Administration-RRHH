using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Security.Policy;

namespace Administration_RRHH.Services.Persistence
{
    public class DeleteCommand : DatabaseConnection
    {
        #region Constructors
        public DeleteCommand() { }

        public DeleteCommand(string connectionString) : base(connectionString) { }
        #endregion

        #region
        public int ExecuteDelete(string query, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection)
                {
                    CommandType = CommandType.Text
                };

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                return _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al eliminar: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
    }//end class
}//end namespace
