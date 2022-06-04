using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST10083941_PROG221_POE.Classes;

namespace ST10083941_PROG221_POE
{
    public partial class frmReport : Form
    {
        //List of expense objects to store the received list from frmMain
        List<Expenses> expense;

        //Constants to keep track of each expense within the list.
        const int GROCERIES = 0;
        const int HOMELOAN = 1;
        const int OTHER = 2;
        const int PHONEBILL = 3;
        const int RENT = 4;
        const int TAX = 5;
        const int TRAVEL = 6;
        const int UTILITY = 7;
        const int VEHICLE = 8;

        public double Income { get; set; }



        public frmReport(object sender, double income)
        {
            InitializeComponent();
            Income = income;
            btnDesc.Text = "Descending " + char.ConvertFromUtf32(0x2193);
            btnAsc.Text = "Ascending " + char.ConvertFromUtf32(0x2191);
            expense = (List<Expenses>)sender;
            DisplayExpenses();
        }

        public void DisplayExpenses()
        {
            string allExpenses = "";
            foreach (Expenses bills in expense)
            {
                allExpenses += bills.Message() + "\n";
            }
            string message = $"Income: R{Income}\nEXPENSES\n\n" + allExpenses;
            rtbAllExpenses.Text = message;
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            List<Expenses> DescendingExpenses = expense.OrderByDescending(bill => bill.Cost).ToList();
            string allExpenses = "";

            foreach (Expenses bills in DescendingExpenses)
            {
                allExpenses += bills.Message() + "\n";
            }
            string message = $"Income: R{Income}\nEXPENSES\n\n" + allExpenses;
            rtbAllExpenses.Text = message;
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            List<Expenses> DescendingExpenses = expense.OrderBy(bill => bill.Cost).ToList();
            string allExpenses = "";

            foreach (Expenses bills in DescendingExpenses)
            {
                allExpenses += bills.Message() + "\n";
            }
            string message = $"Income: R{Income}\nEXPENSES\n\n" + allExpenses;
            rtbAllExpenses.Text = message;
        }
    }
}
