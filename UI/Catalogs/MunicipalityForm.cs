using Administration_RRHH.Domain;
using Administration_RRHH.Services.BusinessLogic;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class MunicipalityForm : Form
    {
        public MunicipalityForm()
        {
            InitializeComponent();
        }

        private void MunicipalityLoad()
        {
            //Crear una instancia de lógica de negocio            
            RegionBusiness rBusiness = new RegionBusiness();
            
            // Configurar el ComboBox con DataSource para vincular objetos completos
            cmbDepartament.DataSource = rBusiness.ReadRegions();
            cmbDepartament.DisplayMember = "Description";  // Propiedad que se muestra al usuario
            cmbDepartament.ValueMember = "Region_Id";       // Propiedad del valor asociado (Region_Id)
        }

        private void clearInputs()
        {
            txtCode.Clear();
            txtMunicipality.Clear();
            cmbDepartament.SelectedIndex = -1; // Deseleccionar cualquier selección en el ComboBox
        }

        private void btnResgister_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            //Validar que  los campos de Municipios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtMunicipality.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos faltantes.", "Campos Incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener el proceso de registro si hay campos incompletos
            }
                        
            // Si todo esta bien, se procede con el registro
            try
            {
                //Crear instancia para Municipio con los datos ingresados
                Municipality newMunicipality = new Municipality
                {
                    MunicipalityCode = txtCode.Text.Trim(),
                    MunicipalityName = txtMunicipality.Text.Trim(),
                    RegionId  = (Regions)cmbDepartament.SelectedItem // Obtener el objeto Region seleccionado
                };

                MunicipalityBusiness municipalityBusiness = new MunicipalityBusiness(newMunicipality); //Inicializar con el objeto actual
                int result = municipalityBusiness.AddMunicipality();

                //Validar el resultado del registro
                if (result > 0)
                {
                    MessageBox.Show("El nuevo Municipio fue registrado exitosamente.", "Operación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // clearInputs(); // Limpiar los campos después del registro

            }
            catch (Exception logic)
            {
                MessageBox.Show($"Ocurrió un error al registrar el Municipio: {logic.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Endn try-catch

             //Limpiar los campos después del registro
            clearInputs();
        }

        private void MunicipalityForm_Load(object sender, EventArgs e)
        {
            MunicipalityLoad();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra el formulario actual
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Ventana de dialogo
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Confirmar",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Si el usuario confirma la cancelación, se limpian los campos
            if (result == DialogResult.Yes)
            {
                clearInputs();
            }
        }
    } // end of MunicipalityForm class
} // end of namespace
