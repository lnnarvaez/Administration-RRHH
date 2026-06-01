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
            
            
        }

        private void btnListEmployees_Click(object sender, EventArgs e)
        {
            FrmListEmployee viewListEmpployee = new FrmListEmployee();
            viewListEmpployee.Show();
            this.Hide();

        }//end-btnListEmployees_Click
    }//end class
}//end namespace
