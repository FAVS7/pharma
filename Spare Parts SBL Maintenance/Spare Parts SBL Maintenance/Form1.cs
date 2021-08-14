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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMaterialCharge materialCharge = new frmMaterialCharge();
            materialCharge.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMaterialDischarge discharge = new frmMaterialDischarge();
            discharge.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUbication ubication = new frmUbication();
            ubication.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
 
        }
    }
}
