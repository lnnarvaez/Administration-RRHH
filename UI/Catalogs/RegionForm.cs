using Administration_RRHH.Services.BusinessLogic;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class RegionForm : Form
    {
        public RegionForm()
        {
            InitializeComponent();
        }

        // Regresar el estado de input a su estado inicial
        private void clearInputs()
        {
            mskRegionCode.Clear();
            txtRegionName.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            if (!mskRegionCode.MaskCompleted)
            {
                // Handle the case where the mask is not complete
                msg = "Por favor ingrese un código de región válido.";
            }

            if (string.IsNullOrEmpty(txtRegionName.Text))
            {
                msg = "Por favor ingrese un nombre de departamento valido";
            }

            //Validar si los campos son válidos antes de proceder con el registro
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Si todo esta bien, se procede con el registro
            try
            {

                // lógica para registrar la región en tu base de datos o sistema
                Domain.Region newRegion = new Domain.Region(); //Domain .Region es la clase que representa la entidad Región en tu dominio
                newRegion.RegionCode = mskRegionCode.Text.Trim();
                newRegion.Description = txtRegionName.Text.Trim();

                RegionBusiness regionService = new RegionBusiness(newRegion); //Inicializar con el objeto actual
                int result = regionService.AddRegion();

                //Validar el resultado del registro
                if (result > 0)
                {
                    MessageBox.Show("El nuevo Departamento fue registrado exitosamente.", "Operación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clearInputs(); // Limpiar los campos después del registro
            }
            catch (Exception logic)
            {
                MessageBox.Show($"Ocurrió un error al registrar el Departamento: {logic.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Endn try-catch
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Confirmar la cancelación antes de limpiar los campos
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea cancelar el registro?", 
                                                    "Confirmar Cancelación", MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Question))
            {
                clearInputs(); // Limpiar los campos si el usuario confirma la cancelación
            }
        }
    }//end class
} //end namespace
