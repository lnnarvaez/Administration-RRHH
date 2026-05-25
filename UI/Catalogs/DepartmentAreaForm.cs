using Administration_RRHH.Service;
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
    public partial class DepartmentAreaForm : Form
    {
        public DepartmentAreaForm()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0; // Selecciona el primer ítem por defecto
        }

        private void DepartmentAreaForm_Load(object sender, EventArgs e)
        {
            // 'using' garantiza que Dispose() se llame al salir del bloque,
            // cerrando la conexión y liberando recursos automáticamente.
            using SelectQuery query = new SelectQuery();

            string sql = "SELECT DepartmentCode, Description " +
                         "FROM Region ORDER BY DepartmentCode ASC";

            DataTable tabla = query.ExecuteSelect(sql);

            // Vincular el resultado al DataGridView
            dgv_DepartmentList.DataSource = tabla;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
