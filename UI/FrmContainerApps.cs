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
        }

        private void CustomizeNavigation()
        {
            // Customize the navigation bar appearance
            pnlSubMenuCatalog.Visible = false; // Hide the submenu by default
            pnlSubMenuEmployee.Visible = false; // Hide the submenu by default
            pnlSubMenuContracts.Visible = false; // Hide the submenu by default
            pnlSubMenuPayroll.Visible = false; // Hide the submenu by default
            pnlSubMenuReport.Visible = false; // Hide the submenu by default
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
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } //end-OpenChildForm

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuCatalog);
            lblMenu.Text = "";
            lblMenu.Text = "Catálogo";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuEmployee);
            lblMenu.Text = "";
            lblMenu.Text = "Empleados";
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuContracts);
            lblMenu.Text = "";
            lblMenu.Text = "Contratos";
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuPayroll);
            lblMenu.Text = "";
            lblMenu.Text = "Nómina";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlSubMenuReport);
            lblMenu.Text = "";
            lblMenu.Text = "Reportes";
        }
    }//end-class
}//end-namespace
