using Administration_RRHH.Models;

namespace Administration_RRHH
{
    public partial class FrmEmployee : Form
    {
        Employee myEmployee; //Variable de instancia para almacenar el objeto Employee creado a través del formulario

        public FrmEmployee()
        {
            myEmployee = new Employee(); //Inicializar la variable de instancia
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            myEmployee.IdentityCard = mskCedula.Text;
            myEmployee.Name = txtName.Text;
            

            //Almacenar el objeto Employee creado a través del formulario en una variable de instancia para su uso posterior
            if (myEmployee.AddEmployee())
            {
                MessageBox.Show("Empleado registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el empleado. Verifique los datos ingresados.");
            }
        }
        
    }
}
