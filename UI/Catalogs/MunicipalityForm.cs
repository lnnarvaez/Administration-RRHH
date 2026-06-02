using Administration_RRHH.Service.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class MunicipalityForm : Form
    {
        public MunicipalityForm()
        {
            InitializeComponent();
        }

        private void MunicipalityForm_Load(object sender, EventArgs e)
        {
            // 'using' garantiza que Dispose() se llame al salir del bloque,
            // cerrando la conexión y liberando recursos automáticamente.
            using SelectQuery query = new SelectQuery();

            string sql = "SELECT MunicipalityCode, MunicipalityName " +
                         "FROM Municipality ORDER BY MunicipalityCode ASC";

            DataTable tabla = query.ExecuteSelect(sql);

            // Vincular el resultado al DataGridView
            dgvListMunicipality.DataSource = tabla;
        }
    }
}
