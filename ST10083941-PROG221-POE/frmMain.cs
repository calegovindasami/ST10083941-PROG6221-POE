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
    public partial class frmMain : Form
    {
        public string Groceries { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {

            Expenses exp = new();
            this.Hide();
            exp.ShowDialog();
            this.Show();
            rtbExpenses.Text = exp.Groceries.ToString();
            
        }

    }
}
