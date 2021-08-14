using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spare_Parts_SBL_Maintenance
{
    public partial class frmMaterialCharge : Form
    {
        public frmMaterialCharge()
        {
            InitializeComponent();
        }

        private void btnSaveCharge_Click(object sender, EventArgs e)
        {
            if (Entradas.SelectedIndex == 0) { MessageBox.Show("Ingreso a entradas"); }
            else { MessageBox.Show("Ingreso a altas"); }
        }

          private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
