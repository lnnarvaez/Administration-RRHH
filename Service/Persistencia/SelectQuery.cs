using Microsoft.Data.SqlClient;
using System.Data;

namespace Administration_RRHH.Service.Persistencia
{
    /// <summary>
    /// Subclase para ejecutar consultas SELECT.
    /// Devuelve datos como DataTable para uso directo en controles Windows Forms
    /// (DataGridView, ComboBox, ListBox, etc.).
    /// </summary>
    public class SelectQuery: DatabaseConnection
    {
        // Hereda _connection y _command de la superclase DatabaseConnection.

        public SelectQuery() : base() { }
        public SelectQuery(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta una consulta SELECT y devuelve un DataTable con los resultados.
        /// </summary>
        /// <param name="query">Consulta SQL parametrizada.</param>
        /// <param name="parameters">Parámetros SQL (previenen inyección SQL).</param>
        /// <returns>DataTable con los registros encontrados.</returns>
        public DataTable ExecuteSelect(string query,
                                       SqlParameter[]? parameters = null)
        {
            DataTable result = new DataTable();

            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                using SqlDataAdapter adapter = new SqlDataAdapter(_command);
                adapter.Fill(result);
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar SELECT: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        } //end exe


    } //end - ExecuteSelect
}//end-namespace
