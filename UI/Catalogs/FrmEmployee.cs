using Administration_RRHH.Domain;

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Obtener los datos del formulario y asignarlos a las propiedades del objeto Employee





            if (_employee.AddEmployee())
            {
                MessageBox.Show("Empleado registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar el empleado");
            }
        }
    }
}
