using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Input;

namespace Administration_RRHH.Services
{
    /// <summary>
    /// Subclase para ejecutar operaciones INSERT.
    /// Puede devolver el ID generado (IDENTITY) del nuevo registro.
    /// </summary>
    public class InsertCommand : DatabaseConnection
    {
        public InsertCommand() : base() { }
        public InsertCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un INSERT y devuelve el número de filas afectadas.
        /// </summary>
        /// <param name="query">Sentencia INSERT parametrizada.</param>
        /// <param name="parameters">Parámetros SQL.</param>
        /// <returns>Número de filas insertadas (generalmente 1).</returns>
        public int ExecuteInsert(string query, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                return _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar INSERT: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

    }//end class
}//end namespace
