using Administration_RRHH.Domain;
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
    public partial class FrmListEmployee : Form
    {
        public FrmListEmployee()
        {
            InitializeComponent();
        }

        private void FrmListEmployee_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string clave = mskIdentityCard.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Introduzca una cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Intentar obtener la fuente original (si previamente guardaste la original en Tag, úsala)
            object source = dataGridView1.Tag ?? dataGridView1.DataSource;

            // Si es BindingSource, sacamos su DataSource real
            if (source is BindingSource bs) source = bs.DataSource;

            // Caso: DataTable
            if (source is DataTable dt)
            {
                // Filtrar por columna "colCedula" (escapar comillas simples)
                string safe = clave.Replace("'", "''");
                DataRow[] rows = dt.Select($"colCedula = '{safe}'");
                var filtered = dt.Clone();
                foreach (var r in rows) filtered.ImportRow(r);
                dataGridView1.DataSource = filtered;
                return;
            }

           

            MessageBox.Show("No se pudo filtrar: tipo de origen desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }//end class
}//end namespace
