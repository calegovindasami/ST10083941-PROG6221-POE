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

            //Removes numericUpDown controls.
            RemoveNumericUpDownControls(nudInterest);
            RemoveNumericUpDownControls(nudPropertyPrice);
            RemoveNumericUpDownControls(nudRepayment);
            RemoveNumericUpDownControls(nudTotalDeposit);
        }

        //Method created to remove the passed in NumericUpDown components arrows/controls 
        public void RemoveNumericUpDownControls(NumericUpDown nud)
        {
            nud.Controls[0].Visible = false;
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
        
        //Sets the total deposit maximum value based on the property price.
        private void nudPropertyPrice_ValueChanged(object sender, EventArgs e)
        {
            nudTotalDeposit.Maximum = nudPropertyPrice.Value;
        }
    }
}
