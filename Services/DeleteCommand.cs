using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Administration_RRHH.Services
{
    public class DeleteCommand : DatabaseConnection
    {
        public DeleteCommand() : base() { }
        public DeleteCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un DELETE y devuelve el número de filas eliminadas.
        /// </summary>
        /// <param name="query">Sentencia DELETE parametrizada.</param>
        /// <param name="parameters">Parámetros SQL.</param>
        /// <returns>Número de filas eliminadas.</returns>
        public int ExecuteDelete(string query, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                int rowsAffected = _command.ExecuteNonQuery();

                if (rowsAffected == 0)
                    throw new Exception("El DELETE no eliminó ningún registro. " +
                                        "Verifica que el ID exista en la base de datos.");

                return rowsAffected;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar DELETE: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }//end class
}//end namespace
