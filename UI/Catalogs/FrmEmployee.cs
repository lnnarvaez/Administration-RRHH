using Administration_RRHH.Domain;
using Administration_RRHH.UI.Catalogs;

namespace Administration_RRHH
{
    public partial class FrmEmployee : Form
    {
        //Crear instancia de la clase Employee
        Employee _employee;
        public FrmEmployee()
        {
            InitializeComponent();
            _employee = new Employee();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN LOCAL (Formulario) - Práctico e inmediato
            /*if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. CAPTURA
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                };

                // 3. ENVÍO A LA LÓGICA
                ClienteService clienteService = new ClienteService();
                clienteService.RegistrarCliente(nuevoCliente);

                MessageBox.Show("Registro guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Aquí cae si la Lógica de Negocio encuentra un problema (ej. Correo duplicado)
                MessageBox.Show(ex.Message, "Error de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void btnListEmployees_Click(object sender, EventArgs e)
        {
            FrmListEmployee viewListEmpployee = new FrmListEmployee();
            viewListEmpployee.Show();
            this.Hide();

        }//end-btnListEmployees_Click
    }//end class
}//end namespace
