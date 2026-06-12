using Administration_RRHH.Domain;
using Administration_RRHH.Services.BusinessLogic;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class RegionsMainForm : Form
    {
        //Definir una lista que contenga los datos de las regiones para mostrar en el DataGridView
        List<Regions> regionsList;

        //Tener la captura del objeto que seleccione en el GridView para mostrar los datos en los campos de texto
        Regions selectedRegion;

        public RegionsMainForm()
        {
            InitializeComponent();
            regionsList = new List<Regions>();
            selectedRegion = new Regions();
        }

        private void RegionsMainForm_Load(object sender, EventArgs e)
        {
            //Comunicar con la clase intermedia para obtener la lista de regiones y mostrarla en el DataGridView
            try
            {
                RegionBusiness rBusiness = new RegionBusiness(); //crear una instancia de la clase lógica de negocio

                //Recuperar la lista de regiones utilizando el método ReadRegions() de la clase RegionBusiness
                regionsList = rBusiness.ReadRegions(); //obtener la lista de regiones

                //Indicar que no se autogeneren las columnas, ya que se van a crear manualmente
                dgDepartment.AutoGenerateColumns = false;

                //indicar que la columna se llene con el valor de la propiedad RegionCode de la clase Regions
                colRegionCode.DataPropertyName = "RegionCode";
                colRegionName.DataPropertyName = "Description";
                colActive.DataPropertyName = "Enabled";

                dgDepartment.DataSource = this.regionsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las regiones: " + ex.Message);
            }//end try
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra el formulario actual
        }

        private void dgDepartment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDepartment.CurrentRow != null)
            {
                selectedRegion = (Regions)dgDepartment.CurrentRow.DataBoundItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Funcionalidad Edición en pruieba:" + selectedRegion.Description);
            RegionForm regionModals = new RegionForm(selectedRegion);
            //Buscar el centro de la pantalla para mostrar el formulario modal
            regionModals.StartPosition = FormStartPosition.CenterScreen;

            regionModals.ShowDialog();
        }
    }//end class
} //end namespace
