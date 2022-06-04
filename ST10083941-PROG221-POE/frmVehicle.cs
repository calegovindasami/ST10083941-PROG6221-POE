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
        //Properties of the vehicle class.
        public string ModelMake { get; set; }
        public double PurchasePrice { get; set; }
        public double TotalDeposit { get; set; }
        public double InterestRate { get; set; }
        public double InsurancePremium { get; set; }
        public frmVehicle()
        {
            InitializeComponent();
            RemoveNumericUpDownControls(nudPurchasePrice);
            RemoveNumericUpDownControls(nudTotalDeposit);
            RemoveNumericUpDownControls(nudInterest);
            RemoveNumericUpDownControls(nudInsurance);
        }

        //Sends the data to frmMain.
        private void btnSave_Click(object sender, EventArgs e)
        {
            ModelMake = tbModelMake.Text;
            PurchasePrice = Convert.ToDouble(nudPurchasePrice.Value);
            TotalDeposit = Convert.ToDouble(nudTotalDeposit.Value);
            InterestRate = Convert.ToDouble(nudInterest.Value);
            InsurancePremium = Convert.ToDouble(nudInsurance.Value);
            this.Close();
        }
        //Sets the maximum deposit value based on the purchase price.
        private void nudPurchasePrice_ValueChanged(object sender, EventArgs e)
        {
            nudTotalDeposit.Maximum = nudPurchasePrice.Value;
        }

        //Removes the up down controls of the numericupdown components
        public void RemoveNumericUpDownControls(NumericUpDown nud)
        {
            nud.Controls[0].Visible = false;
        }
    }
}
