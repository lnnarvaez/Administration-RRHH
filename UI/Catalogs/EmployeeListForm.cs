using Administration_RRHH.Domain;
using Administration_RRHH.Services.BusinessLogic;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class EmployeeListForm : Form
    {
        //Definir una lista de empleados para mostrar en el DataGridView
        //List<Employee> employeeList;

        private Employee _employeeSelect;
        private List<Employee> _employees;

        public EmployeeListForm()
        {
            InitializeComponent();
            _employeeSelect = new Employee();
            _employees = new List<Employee>();
        }

        private void FrmListEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            //Comunicar con la clase intermedia para obtener la lista de regiones y mostrarla en el DataGridView
            try
            {
                //crear una instancia de la clase lógica de negocio
                EmployeeBusiness employeeList = new EmployeeBusiness();

                //Indicar que no se autogeneren las columnas, ya que se van a crear manualmente                
                dgListEmployee.AutoGenerateColumns = false;

                _employees = employeeList.ListEmployees();
                dgListEmployee.DataSource = _employees; //llenar el DataGridView con la lista de empleados
                //indicar que la columna se llene con el valor de la propiedad Employee
                colIdNumber.DataPropertyName = "IdNumber";
                colInss.DataPropertyName = "Inss";
                colNames.DataPropertyName = "Name";
                colSurname.DataPropertyName = "Surname";
                colPhone.DataPropertyName = "Phone";
                colEmail.DataPropertyName = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar registro de Empleados: " + ex.Message, "Datos no Accesibles",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end try
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!mskIdNumber.MaskCompleted)
            {
                MessageBox.Show("Introduzca un número de cédula para aplicar búsqueda.", "Datos Incompletos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string idNumber = mskIdNumber.Text.Trim();
            Employee? employee = _employees
                .FirstOrDefault(e => string.Equals(e.IdNumber, idNumber, StringComparison.OrdinalIgnoreCase));

            if (employee is null)
            {
                MessageBox.Show("No se encontró un empleado con la cédula indicada.", "Empleado no encontrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskIdNumber.Clear(); //Aplicar limpieza del campo para que el usuario pueda ingresar una nueva cédula
                mskIdNumber.Focus(); //Regresar el foco al campo de búsqueda para que el usuario pueda corregir la entrada
                return;
            }

            dgListEmployee.DataSource = new List<Employee> { employee };
            dgListEmployee.ClearSelection();
            dgListEmployee.Rows[0].Selected = true;
            dgListEmployee.CurrentCell = dgListEmployee.Rows[0].Cells[0];
            _employeeSelect = employee;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Cargar formulario con la visualización de los datos del empleado seleccionado para su edición
            FrmEmployee emplEdit = new FrmEmployee(_employeeSelect);
            //Buscar el centro de la pantalla para mostrar el formulario modal
            emplEdit.StartPosition = FormStartPosition.CenterScreen;
            this.Close(); //Ocultar el formulario actual
            emplEdit.ShowDialog();
        }

        private void dgListEmployee_SelectionChanged(object sender, EventArgs e)
        {

            if (dgListEmployee.CurrentRow != null)
            {
                Municipality m = new Municipality(); //Aplicar para identificar el objeto municipio
                
                _employeeSelect = (Employee)dgListEmployee.CurrentRow.DataBoundItem;

                _employeeSelect.Municipality_Id = m.GetMunicipalityById(_employeeSelect.Municipality_Id.MunicipalityId);

                // Repetir procedimiento para recuperar el objeto MaritalStatus
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún empleado.", "Empleado Pendiente",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Verificar si hay alguna celda seleccionada en el DataGridView
            if (dgListEmployee.CurrentRow != null)
            {
                _employeeSelect = (Employee)dgListEmployee.CurrentRow.DataBoundItem;
                //Mensaje de Advertencia para confirmación de eliminación del registro
                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el empleado con cédula " +
                                                      $"{_employeeSelect.IdNumber}?", "Confirmar Eliminación",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //Si el usuario confirma la eliminación, proceder a eliminar el registro
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        EmployeeBusiness employeeBusiness = new EmployeeBusiness();
                        int rows = employeeBusiness.DeleteEmployee(_employeeSelect.IdNumber);

                        if (rows > 0)
                        {
                            MessageBox.Show("El Empleado ha sido dado de baja exitosamente.", "Eliminación Exitosa",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un empleado para eliminar.", "Empleado no encontrado",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar empleado: " + ex.Message, "Datos no Accesibles",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Cerrar el formulario actual
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            //Definir una instancia de la clase FrmEmployee para mostrar el formulario de creación de un nuevo empleado
            FrmEmployee EmployeView = new FrmEmployee();

            //Buscar el centro de la pantalla para mostrar el formulario modal
            EmployeView.StartPosition = FormStartPosition.CenterScreen;

            this.Close(); //Cerrar el formulario actual para mostrar el formulario de creación de un nuevo empleado
            EmployeView.ShowDialog();             

        }
    }//end class
}//end namespace
