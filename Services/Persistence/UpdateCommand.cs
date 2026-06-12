using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Services.Persistence
{
    public class UpdateCommand : DatabaseConnection
    {
        #region Constructors
        //Constroctores
        public UpdateCommand() : base() { }

        public UpdateCommand(string connectionString) : base(connectionString) { }

        #endregion

        #region Methods
        public int ExecuteUpdate(string query, SqlParameter[]? parameters = null)
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
                throw new Exception($"Error al actualizar: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        #endregion

    }//end class
}// end namespace
