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
    public partial class frmVehicle : Form
    {

        public string ModelMake { get; set; }
        public double PurchasePrice { get; set; }
        public double TotalDeposit { get; set; }
        public double InterestRate { get; set; }
        public double InsurancePremium { get; set; }
        public frmVehicle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ModelMake = tbModelMake.Text;
            PurchasePrice = Convert.ToDouble(nudPurchasePrice.Value);
            TotalDeposit = Convert.ToDouble(nudTotalDeposit.Value);
            InterestRate = Convert.ToDouble(nudInterest.Value);
            InsurancePremium = Convert.ToDouble(nudInsurance.Value);
            this.Close();
        }
    }
}
