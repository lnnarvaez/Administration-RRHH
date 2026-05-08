using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administration_RRHH.UI.Dashboard
{
    public partial class FrmContainer : Form
    {
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
                pnlCatalogSubMenu.Visible = false;

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

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            ShowSubMenuPanel(pnlCatalogSubMenu);
            lblSubMenu.Text = "Catálogo";

        }//End - btnCatalog_Click

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HideSubMenuPanel(); //Oculta submenús antes de mostrar el submenú de empleados
            ShowSubMenuPanel(pnlSubMenuEmployee); //Muestra el submenú de empleados
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            HideSubMenuPanel(); //Oculta submenús antes de mostrar el submenú de contratos
            ShowSubMenuPanel(pnlSubMenuContract); //Muestra el submenú de contratos
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            HideSubMenuPanel(); //Oculta submenús antes de mostrar el submenú de nómina
            ShowSubMenuPanel(pnlSubMenuPayroll);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            HideSubMenuPanel(); //Oculta submenús antes de mostrar el submenú de reportes
            ShowSubMenuPanel(pnlSubMenuReport);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            HideSubMenuPanel(); //Oculta submenús antes de mostrar el submenú de administración
            ShowSubMenuPanel(pnlSubMenuAdmin);
        }
    }//end class
} //end namespace
