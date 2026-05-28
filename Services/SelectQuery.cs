using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Administration_RRHH.Services
{
    /// <summary>
    /// Subclase para ejecutar consultas SELECT.
    /// Devuelve datos como DataTable para uso directo en controles Windows Forms
    /// (DataGridView, ComboBox, ListBox, etc.).
    /// </summary>
    public class SelectQuery: DatabaseConnection
    {
        //heredar constructores de la clase base
        public SelectQuery() : base() { }

        public SelectQuery(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta una consulta SELECT con parámetros opcionales y devuelve los resultados en un DataTable.
        /// </summary>
        /// <param name="query">Consulta SQL Parametrizada</param>
        /// <param name="parameters">Parámetros SQL (previene inyección de SQL)</param>
        /// <returns>DataTable con los resultados</returns>
        public DataTable ExecuteSelect (string query, SqlParameter[] parameters = null)
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
                adapter.Fill(result); // Llenar el DataTable con los resultados de la consulta
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al intentar obtener resultados " +
                    $"{ex.Message}", ex);
            }
            finally
            { 
                CloseConnection(); //Cerrar la conexión en el bloque finally
                                   //para asegurar que se ejecute siempre
            }

            return result;
        }// end of ExecuteSelect
    }//End of class
}//End of namespace
