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
    public partial class Mortgage : Form
    {

        public double PropertyPrice { get; set; }
        public double TotalDeposit { get; set; }
        public double InterestRate { get; set; }
        public double Repayment { get; set; }
        public Mortgage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PropertyPrice = Convert.ToDouble(nudPropertyPrice.Value);
            TotalDeposit = Convert.ToDouble(nudTotalDeposit.Value);
            InterestRate = Convert.ToDouble(nudInterest.Value);
            Repayment = Convert.ToDouble(nudRepayment.Value);
            this.Close();
        }
    }
}
