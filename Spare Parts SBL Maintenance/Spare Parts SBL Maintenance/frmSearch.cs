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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            Image path = Image.FromFile(@"C:\Users\FAVS\Downloads\password.PNG");
            pbxImageSearch.Image = (path);
        }
    }
}
