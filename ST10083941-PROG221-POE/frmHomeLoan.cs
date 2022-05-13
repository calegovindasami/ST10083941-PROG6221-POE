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
    public partial class frmHomeLoan : Form
    {
        //Property/properties of expense so that this value(s) can be extracted in the main form using this forms object.
        public double PropertyPrice { get; set; }
        public double TotalDeposit { get; set; }
        public double InterestRate { get; set; }
        public int MonthsToRepay { get; set; }
        public frmHomeLoan()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Sets property value and closes the form.
            PropertyPrice = Convert.ToDouble(nudPropertyPrice.Value);
            TotalDeposit = Convert.ToDouble(nudTotalDeposit.Value);
            InterestRate = Convert.ToDouble(nudInterest.Value);
            MonthsToRepay = Convert.ToInt32(nudRepayment.Value);
            this.Close();
        }
    }
}
