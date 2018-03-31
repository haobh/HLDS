using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMC.Service;

namespace UMC.WApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mns_Shift_Click(object sender, EventArgs e)
        {
            frmShift frmshift = new frmShift();
            frmshift.Show();
        }
    }
}
