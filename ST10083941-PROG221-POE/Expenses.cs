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
    public partial class Expenses : Form
    {

        public double Groceries { get; set; }
        public double Utilities { get; set; }
        public double Travel { get; set; }
        public double PhoneBill { get; set; }
        public double Other { get; set; }
        public Expenses()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Groceries = Convert.ToDouble(nudGroceries.Value);
            Utilities = Convert.ToDouble(nudUtilities.Value);
            Travel = Convert.ToDouble(nudTravel.Value);
            PhoneBill = Convert.ToDouble(nudPhoneBill.Value);
            Other = Convert.ToDouble(nudOther.Value);
            this.Close();
        }
    }
}
