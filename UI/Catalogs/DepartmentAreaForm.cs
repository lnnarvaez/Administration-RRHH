using Administration_RRHH.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class DepartmentAreaForm : Form
    {
        public DepartmentAreaForm()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0; // Selecciona el primer ítem por defecto
        }

        private void DepartmentAreaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
