using Administration_RRHH.UI.Catalogs;

namespace Administration_RRHH.UI.Dashboard
{
    public partial class FrmContainer : Form
    {
        //? después del form indica que la variable puede ser nula, lo que es útil para evitar
        //errores de referencia nula al trabajar con formularios que pueden no estar siempre
        //activos o inicializados.
        private Form? _activeForm = null; //Variable para almacenar el formulario activo
        public FrmContainer()
        {
            InitializeComponent();
            lblSubMenu.Text = string.Empty; //Inicializar el texto del submenú como vacío
            lblItems.Text = string.Empty;
            CustomizeNavigation(); //Mandar cargar cuando se cree el objeto
        }

        /// <summary>
        /// Configura la visibilidad de los paneles de navegación secundarios, ocultando todos los submenús del menú
        /// principal.
        /// </summary>
        /// <remarks>Llame a este método para restablecer la navegación a su estado inicial, asegurando
        /// que ningún submenú secundario esté visible. Útil al cambiar de sección o al inicializar la interfaz de
        /// usuario.</remarks>
        #region Customization of sidebar navigation
        public void CustomizeNavigation()
        {
            // Ocultar las paneles de Menú
            pnlCatalogSubMenu.Visible = false;
            pnlSubMenuEmployee.Visible = false;
            pnlSubMenuContract.Visible = false;
            pnlSubMenuPayroll.Visible = false;
            pnlSubMenuReport.Visible = false;
            pnlSubMenuAdmin.Visible = false;
        }//End - CustomizeNavigatio

        /// <summary>
        /// Oculta todos los paneles de submenú visibles en la interfaz de usuario.
        /// </summary>
        /// <remarks>Utilice este método para garantizar que ningún submenú permanezca visible antes de
        /// mostrar un nuevo submenú o al restablecer la vista. Este método no afecta a otros elementos de la interfaz
        /// de usuario fuera de los paneles de submenú.</remarks>
        public void HideSubMenuPanel()
        {
            if (pnlCatalogSubMenu.Visible == true)
            {
                pnlCatalogSubMenu.Visible = false;
            }

            if (pnlSubMenuEmployee.Visible == true)
                pnlSubMenuEmployee.Visible = false;

            if (pnlSubMenuContract.Visible == true)
                pnlSubMenuContract.Visible = false;

            if (pnlSubMenuPayroll.Visible == true)
                pnlSubMenuPayroll.Visible = false;

            if (pnlSubMenuReport.Visible == true)
                pnlSubMenuReport.Visible = false;

            if (pnlSubMenuAdmin.Visible == true)
                pnlSubMenuAdmin.Visible = false;

        }//end HideMenuPanel

        public void ShowSubMenuPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenuPanel();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }// end ShowSubMenuPanel


        private void OpenChildForm(Form childForm)
        {
            //Cerrar el formulario que actualmente se encuentre en uso
            if (_activeForm != null)
            {
                _activeForm.Dispose();
                pnlContainer.Controls.Clear(); //Limpiar los controles del panel contenedor para evitar superposiciones
            }
            _activeForm = childForm;

            //Configurar Formulario hijo
            //Indica que el formulario no es de nivel superior, lo que permite que se muestre dentro de otro formulario
            childForm.TopLevel = false;

            //Asignar un Dockfill al formulario hijo para que ocupe todo el espacio disponible dentro del panel contenedor
            //childForm.Dock = DockStyle.None;

            Panel hostPanel = new Panel(); //Crear un panel anfitrión para alojar el formulario hijo
            hostPanel.Dock = DockStyle.Fill;
            //hostPanel.Padding = new Padding(8); //Eliminar cualquier espacio alrededor del formulario hijo dentro del panel anfitrión

            //Mantener el tamaño original del formulario hijo sin estirarlo para llenar el panel anfitrión y
            //Establecer la posición del formulario hijo como manual para controlar su ubicación dentro del panel anfitrión
            childForm.StartPosition = FormStartPosition.Manual;

            //Centrar el formulario hijo dentro del panel anfitrión
            int x = (hostPanel.Width - childForm.Width) / 2;
            int y = (hostPanel.Height - childForm.Height) / 2;

            childForm.Location = new Point(x, y);

            //Volver a recentrar si se cambia de tamaño
            hostPanel.Resize += (s, e) =>
            {
                childForm.Location = new Point(
                    (hostPanel.Width - childForm.Width) / 2,
                    (hostPanel.Height - childForm.Height) / 2
                );
            };

            //Agregar formulario hijo al panel anfitrión y mostrarlo
            hostPanel.Controls.Add(childForm);

            //Agregar host al panel contenedor y mostrar el formulario hijo
            pnlContainer.Controls.Clear(); //Limpiar los controles del panel contenedor para evitar superposiciones
            pnlContainer.Controls.Add(hostPanel);
            childForm.Show();

        }//End - OpenChildForm

        #endregion

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlCatalogSubMenu);
            //Validar si lblSubmenu tiene texto (Indica que estaba activa) para limpiar
            if (!String.IsNullOrEmpty(lblSubMenu.Text))
                lblSubMenu.Text = String.Empty;

            lblSubMenu.Text = "Catálogo";
        }//End - btnCatalog_Click

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuEmployee); //Muestra el submenú de empleados
            //Limpia el texto del submenú para evitar confusión al mostrar el submenú de empleados
            lblSubMenu.Text = "";
            lblSubMenu.Text = "Empleados"; //Actualiza el texto del submenú para reflejar la sección de empleados
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuContract); //Muestra el submenú de contratos
            //Limpia el texto del submenú para evitar confusión al mostrar el submenú de contratos
            lblSubMenu.Text = "";
            lblSubMenu.Text = "Contrataciones";
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuPayroll);
            //Limpia el texto del submenú para evitar confusión al mostrar el submenú de contratos
            lblSubMenu.Text = "";
            lblSubMenu.Text = "Nómina";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuReport);
            lblSubMenu.Text = "";//Limpia el texto del submenú para evitar confusión al mostrar el submenú de reportes
            lblSubMenu.Text = "Reportes";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuAdmin);
            //Limpia el texto del submenú para evitar confusión al mostrar el submenú de administración
            lblSubMenu.Text = "";
            lblSubMenu.Text = "Administración";
        }

        private void btnJobCategory_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de catálogo para mostrar el formulario de categorías laborales
            HideSubMenuPanel();
        }

        private void btnDeparment_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de catálogo para mostrar el formulario de departamentos
            HideSubMenuPanel();
        }

        private void btnEmployeeFile_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de empleados para mostrar el formulario de expediente del empleado
            HideSubMenuPanel();
        }

        private void btnTrainingManagement_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de empleados para mostrar el formulario de gestión de capacitaciones
            HideSubMenuPanel();
        }

        private void btnActiveContracts_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de contratos para mostrar el formulario de contratos activos
            HideSubMenuPanel();
        }

        private void btnPayStubs_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de nómina para mostrar el formulario de colillas de pago
            HideSubMenuPanel();
        }

        private void btnContractStatus_Click(object sender, EventArgs e)
        {
            //Intro Code
            //Oculta el submenú de reportes para mostrar el formulario de estado de contratos
            HideSubMenuPanel();
        }

        private void pctSideBarMenu_Click(object sender, EventArgs e)
        {
            if (pnlSideBar.Width == 240)
            {
                pnlSideBar.Width = 50;
                lblItems.Visible = false; // Oculta el texto de los ítems del menú
            }
            else
            {
                pnlSideBar.Width = 240;
                lblItems.Visible = true; // Muestra el texto de los ítems del menú
            }
        }

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            OpenChildForm(new AuthenticationForm());
        }

        private void btnSideBarMenu_Click(object sender, EventArgs e)
        {
            if (pnlSideBar.Width == 240)
            {
                pnlSideBar.Width = 50;
                lblItems.Visible = false; // Oculta el texto de los ítems del menú
            }
            else
            {
                pnlSideBar.Width = 240;
                lblItems.Visible = true; // Muestra el texto de los ítems del menú
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Cierra el formulario actual y libera los recursos asociados
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new RegionForm());
            OpenChildForm (new RegionsMainForm());
        }

        private void btnMunicipality_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MunicipalityForm());
        }

    }//end class
} //end namespace
