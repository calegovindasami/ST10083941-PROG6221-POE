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
    public partial class frmExpenses : Form
    {
        //Property/properties of expense so that this value(s) can be extracted in the main form using this forms object.

        public double Groceries { get; set; }
        public double Utilities { get; set; }
        public double Travel { get; set; }
        public double PhoneBill { get; set; }
        public double Other { get; set; }
        public frmExpenses()
        {
            InitializeComponent();

            //Removes numericUpDown controls.
            RemoveNumericUpDownControls(nudGroceries);
            RemoveNumericUpDownControls(nudOther);
            RemoveNumericUpDownControls(nudPhoneBill);
            RemoveNumericUpDownControls(nudTravel);
            RemoveNumericUpDownControls(nudUtilities);
        }

        //Method created to remove the passed in NumericUpDown components arrows/controls 
        public void RemoveNumericUpDownControls(NumericUpDown nud)
        {
            nud.Controls[0].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Sets property value and closes the form.
            Groceries = Convert.ToDouble(nudGroceries.Value);
            Utilities = Convert.ToDouble(nudUtilities.Value);
            Travel = Convert.ToDouble(nudTravel.Value);
            PhoneBill = Convert.ToDouble(nudPhoneBill.Value);
            Other = Convert.ToDouble(nudOther.Value);
            this.Close();
        }
    }
}
