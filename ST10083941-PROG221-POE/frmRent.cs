using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10083941_PROG221_POE
{
    public partial class frmRent : Form
    {
        public double Rent { get; set; }
        public frmRent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rent = Convert.ToDouble(nudRent.Value);
            this.Close();
        }
    }
}
