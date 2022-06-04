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
        public double TotalExpenses { get; set; }


        public frmReport(object sender, double income)
        {
            InitializeComponent();
            Income = income;
            btnDesc.Text = "Descending " + char.ConvertFromUtf32(0x2193);
            btnAsc.Text = "Ascending " + char.ConvertFromUtf32(0x2191);
            expense = (List<Expenses>)sender;
            TotalExpenses = CalculateTotalExpense(NotifyAlert);
            DisplayExpenses();
        }

        public void DisplayExpenses()
        {
            List<Expenses> DescendingExpenses = expense.OrderByDescending(bill => bill.Cost).ToList();
            string allExpenses = "";
            foreach (Expenses bills in DescendingExpenses)
            {
                allExpenses += bills.Message() + "\n";
            }
            string availableIncome = $"Total Expenses: R{TotalExpenses}\nAvailable Income: {Income - TotalExpenses}";
            string message = $"Income: R{Income}\n\nEXPENSES\n" + allExpenses + availableIncome;
            rtbAllExpenses.Text = message;
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            DisplayExpenses();
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            List<Expenses> AscendingExpenses = expense.OrderBy(bill => bill.Cost).ToList();
            string allExpenses = "";

            foreach (Expenses bills in AscendingExpenses)
            {
                allExpenses += bills.Message() + "\n";
            }
            string availableIncome = $"Total Expenses: R{TotalExpenses}\nAvailable Income: {Income - TotalExpenses}";
            string message = $"Income: R{Income}\n\nEXPENSES\n" + allExpenses + availableIncome;
            rtbAllExpenses.Text = message;
        }

        public delegate void Expense(double total);

        public void NotifyAlert(double total)
        {
            double percentage = 75.00 / 100.00;
            double percentageIncome = (Income * percentage);
            if (total > percentageIncome)
            {
                MessageBox.Show("Warning! Your expenses exceed 75% of your income.");
            }
        }

        public double CalculateTotalExpense(Expense alert)
        {
            double total = 0;
            foreach (Expenses bill in expense)
            {
                total += bill.Cost;
            }
            alert(total);
            return total;
        }

        
    }
}
