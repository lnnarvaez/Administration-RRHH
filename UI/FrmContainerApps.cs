using Administration_RRHH.UI.admin;
using Administration_RRHH.UI.Catalogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_RRHH.UI
{
    public partial class FrmContainerApps : Form
    {
        private Form? _activeForm = null; // Field to keep track of the currently active child form
        public FrmContainerApps()
        {
            InitializeComponent(); // Initialize the form components
            CustomizeNavigation(); // Customize the navigation bar appearance
            lblMenu.Text = String.Empty; // Clear the menu label text on form load
            lblItems.Text = String.Empty; // Clear the items label text on form load
        }

        private void CustomizeNavigation()
        {
            // Customize the navigation bar appearance
            pnlSubMenuCatalog.Visible = false; // Hide the submenu by default
            pnlSubMenuEmployee.Visible = false; // Hide the submenu by default
            pnlSubMenuContracts.Visible = false; // Hide the submenu by default
            pnlSubMenuPayroll.Visible = false; // Hide the submenu by default
            pnlSubMenuReport.Visible = false; // Hide the submenu by default
            pnlSubMenuAdmin.Visible = false; // Hide the submenu by default
        }//end-CustomizeNavigation


        /// <summary>
        /// Oculta todos los submenús actualmente visibles en la interfaz de usuario.
        /// </summary>
        /// <remarks>Llame a este método para asegurarse de que ningún submenú permanezca visible antes de
        /// mostrar un nuevo submenú. Este método no tiene efecto si todos los submenús ya están ocultos.</remarks>
        private void HideSubMenu()
        {
            // Hide all submenus
            if (pnlSubMenuCatalog.Visible) pnlSubMenuCatalog.Visible = false;
            if (pnlSubMenuEmployee.Visible) pnlSubMenuEmployee.Visible = false;
            if (pnlSubMenuContracts.Visible) pnlSubMenuContracts.Visible = false;
            if (pnlSubMenuPayroll.Visible) pnlSubMenuPayroll.Visible = false;
            if (pnlSubMenuReport.Visible) pnlSubMenuReport.Visible = false;
        }//end-HideSubMenu

        /// <summary>
        /// Shows or hides the specified submenu panel based on its current visibility state.
        /// </summary>
        /// <remarks>If the specified submenu is not currently visible, any other visible submenu will be
        /// hidden before showing the requested submenu. If the submenu is already visible, it will be hidden.</remarks>
        /// <param name="subMenu">The submenu panel to show or hide. Cannot be null.</param>
        private void ShowSubMenuPanel(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu(); // Hide any currently visible submenu
                subMenu.Visible = true; // Show the selected submenu
            }
            else
            {
                subMenu.Visible = false; // Hide the submenu if it's already visible
            }
        }//end-ShowSubMenu

        private void OpenChildForm(Form childForm)
        {
            //Cerrar el formulario activo actual si existe
            if (_activeForm != null)
            {
                _activeForm.Dispose(); //Cerrar el formulario activo actual para liberar recursos
                pnlContainer.Controls.Clear(); //Limpiar los controles del panel
                                               //contenedor para preparar el nuevo formulario
            }
            _activeForm = childForm; //Asignar el nuevo formulario como el formulario activo
            childForm.TopLevel = false; //Configurar el formulario hijo para que no sea un
                                        //formulario de nivel superior
            Panel hostPanel = new Panel(); //Crear un nuevo panel para alojar el formulario hijo
            hostPanel.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.Manual; //Configurar la posición de inicio del formulario hijo como manual

            //Centrar el formulario hijo dentro del panel contenedor
            int x = (hostPanel.Width - childForm.Width / 2);
            int y = (hostPanel.Height - childForm.Height) / 2;

            childForm.Location = new Point(x, y); //Establecer la ubicación del formulario hijo
            //volver a recentrar si se cambia de tamaño el panel contenedor
            hostPanel.Resize += (s, e) =>
            {
                int newX = (hostPanel.Width - childForm.Width) / 2;
                int newY = (hostPanel.Height - childForm.Height) / 2;
                childForm.Location = new Point(newX, newY); //Recentrar el formulario hijo al cambiar el tamaño del panel
            };

            //Agregar el formulario hijo al panel contenedor y mostrarlo
            hostPanel.Controls.Add(childForm); //Agregar el formulario hijo al panel contenedor

            pnlContainer.Controls.Clear(); //Limpiar los controles del panel contenedor para mostrar
                                           //solo el nuevo formulario
            pnlContainer.Controls.Add(hostPanel); //Agregar el panel anfitrión al panel contenedor
            childForm.Show(); //Mostrar el formulario hijo

        } //end-OpenChildForm

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuCatalog);
            //Validar que el campo quede vacío antes de asignar el nuevo valor
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = ""; // Limpiar el texto actual del menú
            lblMenu.Text = "Catálogos /"; // Asignar el nuevo texto al menú

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuEmployee);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = String.Empty; // Limpiar el texto actual del menú
            lblMenu.Text = "Empleados /"; // Asignar el nuevo texto al menú
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuContracts);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = ""; // Limpiar el texto actual del menú
            lblMenu.Text = "Contratos /"; // Asignar el nuevo texto al menú
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuPayroll);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = ""; // Limpiar el texto actual del menú
            lblMenu.Text = "Nómina /"; // Asignar el nuevo texto al menú
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuReport);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = String.Empty; // Limpiar el texto actual del menú
            lblMenu.Text = "Reportes /"; // Asignar el nuevo texto al menú
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuAdmin);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = ""; // Limpiar el texto actual del menú
            lblMenu.Text = "Administración /"; // Asignar el nuevo texto al menú
        }

        private void FrmContainerApps_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Authentication());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMenuSideBar_Click(object sender, EventArgs e)
        {
            if (pnlSideBarLeft.Width == 240)
            {
                pnlSideBarLeft.Width = 60; // Colapsar la barra lateral a un ancho más pequeño
                lblMenu.Visible = false; // Ocultar el texto del menú para ahorrar espacio
                lblItems.Visible = false; // Ocultar el texto de los ítems para ahorrar espacio

            }
            else
            {
                pnlSideBarLeft.Width = 240; // Expandir la barra lateral al ancho original
                lblMenu.Visible = true; // Mostrar el texto del menú nuevamente
                lblItems.Visible = true;
            }

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepartmentAreaForm());
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = ""; // Limpiar el texto actual de los ítems
            lblItems.Text = "Departamentos"; // Asignar el nuevo texto a los ítems
        }

        private void btnMunicipality_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MunicipalityForm());
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = ""; // Limpiar el texto actual de los ítems
            lblItems.Text = "Municipios"; // Asignar el nuevo texto a los ítems
        }
    }//end-class
}//end-namespace
