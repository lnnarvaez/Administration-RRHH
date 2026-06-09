using Administration_RRHH.Domain;
using Administration_RRHH.Services.BusinessLogic;

namespace Administration_RRHH
{
    public partial class FrmEmployee : Form
    {
        //Crear instancia de la clase Employee
        Employee _employee;

        public FrmEmployee()
        {
            InitializeComponent();
            dpkBirthDay.MaxDate = DateTime.Today; // Establecer la fecha máxima permitida para el DateTimePicker             
            _employee = new Employee();
        }

        private void MunicipalityLoad()
        {
            //Crear una instancia de la clase MuniciapalityBusiness           
            MunicipalityBusiness mBusiness = new MunicipalityBusiness();

            // Configurar el ComboBox con DataSource para vincular objetos completos
            cmbMunicipality.DataSource = mBusiness.ReadMunicipalities();
            cmbMunicipality.DisplayMember = "MunicipalityName";  // Propiedad que se muestra al usuario
            cmbMunicipality.ValueMember = "MunicipalityId";    // Propiedad del valor asociado (Municipality_Id)            
        }

        private void MaritalStatusLoad()
        {
            //Crear una instancia de la clase MaritalStatusBusiness
            MaritalStatusBusiness mBusiness = new MaritalStatusBusiness();

            // Configurar el ComboBox con DataSource para vincular objetos completos
            cmbMaritalStatus.DataSource = mBusiness.ReadMaritalStatuses();
            cmbMaritalStatus.DisplayMember = "DescriptionStatus";  // Propiedad que se muestra al usuario
            cmbMaritalStatus.ValueMember = "MaritalStatusId";    // Propiedad del valor asociado (MaritalStatus_Id)   
        }

        private void clearInputs()
        {
            //Limpiar los campos del formulario después de registrar un nuevo empleado
            mskCedula.Clear();
            mskInss.Clear();
            txtName.Clear();
            txtSurname.Clear();
            dpkBirthDay.Value = DateTime.Today; // Restablecer al valor predeterminado
            cmbChildren.SelectedIndex = 0; // Restablecer al primer elemento (0 hijos)
            txtEmail.Clear();
            mskPhone.Clear();
            txtAddress.Clear();
            cmbMunicipality.SelectedIndex = -1; // Deseleccionar cualquier municipio seleccionado
            cmbMaritalStatus.SelectedIndex = -1; // Deseleccionar cualquier estado civil seleccionado
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Cerrar el formulario actual
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            //Cargar los municipios en el ComboBox al cargar el formulario
            MunicipalityLoad();

            //Cargar los estados civiles en el ComboBox al cargar el formulario
            MaritalStatusLoad();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string msg = string.Empty; // Variable para almacenar mensajes de validación

            //Validar que los controles MskedTextBox cumplan con el formato requerido
            if (!mskCedula.MaskFull || !mskInss.MaskFull || !mskPhone.MaskFull)
                msg = "Se identifican datos incompletos o incorrectos: Cédula, INSS o Teléfono \n";
            
            if (cmbMunicipality.SelectedItem is null)
            {
                msg = "No se ha indicado ningun Municipio valido";
                cmbMunicipality.Focus(); // Establecer el foco en el ComboBox de Municipio para que el usuario lo corrija
            }

            //Validar que se haya seleccioado una fecha de nacimiento válida
            if (!(_employee.ValidateBirthDate()))
            {
                msg +=  "La fecha de nacimiento no es válida. Asegúrese de que el empleado " +
                        "tenga al menos 18 años y que la fecha no sea futura.";
                dpkBirthDay.Focus(); // Establecer el foco en el DateTimePicker para que el usuario lo corrija
            }

            // Si hay errores de validación, mostrar mensaje y salir
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo esta bien, se procede con el registro
            try
            {
                //Crear instancia para Employee y asignar valores desde los controles del formulario
                Employee newEmployee = new Employee
                {
                    IdNumber = mskCedula.Text.Trim(),
                    Inss = mskInss.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Surname = txtSurname.Text.Trim(),
                    BirthDate = DateOnly.FromDateTime(dpkBirthDay.Value),
                    NumberChildren = int.Parse(cmbChildren.Text),
                    Email = txtEmail.Text.Trim(),
                    Phone = mskPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Municipality_Id = (Municipality)cmbMunicipality.SelectedItem,
                    MaritalStatus_Id = (MaritalStatus)cmbMaritalStatus.SelectedItem
                };

                EmployeeBusiness employeeBusiness = new EmployeeBusiness(newEmployee); //Inicializar con el objeto actual
                int result = employeeBusiness.AddEmployee();

                //Validar el resultado del registro
                if (result > 0)
                {
                    MessageBox.Show("El nuevo Empleado fue registrado exitosamente.", "Operación Exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Limpiar los campos después del registro exitoso
                    clearInputs();
                }
            }
            catch (Exception logic)
            {
                MessageBox.Show($"Ocurrió un error al registrar el Empleado: {logic.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//End try-catch
        }


    }//end class
}//end namespace
