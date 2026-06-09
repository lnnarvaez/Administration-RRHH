using Administration_RRHH.Domain;
using Administration_RRHH.Services.BusinessLogic;
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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void FrmListEmployee_Load(object sender, EventArgs e)
        {
            //Comunicar con la clase intermedia para obtener la lista de regiones y mostrarla en el DataGridView
            try
            {
                //crear una instancia de la clase lógica de negocio
                EmployeeBusiness employeeList = new EmployeeBusiness(); 

                //Indicar que no se autogeneren las columnas, ya que se van a crear manualmente                
                dgListEmployee.AutoGenerateColumns = false;

                //indicar que la columna se llene con el valor de la propiedad Employee
                colIdNumber.DataPropertyName = "IdNumber";
                colInss.DataPropertyName = "Inns";
                colNames.DataPropertyName = "Names";
                colSurname.DataPropertyName = "Surname";
                colPhone.DataPropertyName = "Phone";
                colEmail.DataPropertyName = "Email";
                
                dgListEmployee.DataSource = employeeList.ListEmployees(); //llenar el DataGridView con la lista de empleados
                                                                          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Empleaddos: " + ex.Message);
            }//end try
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string clave = mskIdNumber.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Introduzca una cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Intentar obtener la fuente original (si previamente guardaste la original en Tag, úsala)
            object source = dgListEmployee.Tag ?? dgListEmployee.DataSource;

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
                dgListEmployee.DataSource = filtered;
                return;
            }

           

            MessageBox.Show("No se pudo filtrar: tipo de origen desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }//end class
}//end namespace
