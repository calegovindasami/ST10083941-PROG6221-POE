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
using System.IO;

namespace ST10083941_PROG221_POE
{
    public partial class frmReport : Form
    {
        //List of expense objects to store the received list from frmMain
        List<Expenses> expense;

        public double Income { get; set; }
        public double TotalExpenses { get; set; }

        //Receives list and income as a parameter and assigns and loads the corresponding methods and variables.
        public frmReport(object sender, double income)
        {
            InitializeComponent();
            Income = income;
            btnDesc.Text = "Descending " + char.ConvertFromUtf32(0x2193);
            btnAsc.Text = "Ascending " + char.ConvertFromUtf32(0x2191);
            expense = (List<Expenses>)sender;
            TotalExpenses = Math.Round(CalculateTotalExpense(ExpenseNotification), 2);
            DisplayExpenses();
        }

        //Displays all the expenses in descending order.
        public void DisplayExpenses()
        {
            List<Expenses> DescendingExpenses = expense.OrderByDescending(bill => bill.Cost).ToList();
            string allExpenses = "";
            foreach (Expenses bills in DescendingExpenses)
            {
                if (bills.Cost > 0)
                {
                    allExpenses += bills.Message() + "\n";
                }
            }
            string message = "";
            string availableIncome = $"\nTotal Expenses: R{TotalExpenses}\nAvailable Income: {Income - TotalExpenses}";
            if (Alert() == true)
            {
                message = $"Income: R{Income}\n\nEXPENSES\n" + allExpenses + availableIncome + "\nWarning! Your expenses have exceeded 75% if your income!";
            }
            else
            {
                message = $"Income: R{Income}\n\nEXPENSES\n" + allExpenses + availableIncome;
            }
            rtbAllExpenses.Text = message;
        }

        //Resets expenses.
        private void btnDesc_Click(object sender, EventArgs e)
        {
            DisplayExpenses();
        }

        //Displays all the expenses in ascending order.
        private void btnAsc_Click(object sender, EventArgs e)
        {
            List<Expenses> AscendingExpenses = expense.OrderBy(bill => bill.Cost).ToList();
            string allExpenses = "";

            foreach (Expenses bills in AscendingExpenses)
            {
                if (bills.Cost > 0)
                {
                    allExpenses += bills.Message() + "\n";
                }
            }
            string message = "";
            string availableIncome = $"\nTotal Expenses: R{TotalExpenses}\nAvailable Income: {Income - TotalExpenses}";
            if (Alert() == true)
            {
                message = $"Income: R{Income}\n\nEXPENSES\n" + allExpenses + availableIncome + "\nWarning! Your expenses have exceeded 75% if your income!";
            }
            else
            {
                message = $"Income: R{Income}\n\nEXPENSES\n" + allExpenses + availableIncome;
            }
            rtbAllExpenses.Text = message;
        }

        //Delegate to track total expense
        public delegate void Expense(double total);

        //Method that notifies user when their expenses exceed 75% of their income.
        public void ExpenseNotification(double total)
        {
            double percentage = 75.00 / 100.00;
            double percentageIncome = (Income * percentage);
            if (total > percentageIncome)
            {
                MessageBox.Show("Warning! Your expenses exceed 75% of your income.");
            }
        }

        //Method to check if the expense exceeds 75% of income
        public bool Alert()
        {
            double percentage = 75.00 / 100.00;
            double percentageIncome = (Income * percentage);
            if (TotalExpenses > percentageIncome)
            {
                return true;
            }
            else return false;
        }

        //Method that calculates total and contains the delegate.
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

        //Saves the budget in a textfile.
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Expenses> DescendingExpenses = expense.OrderByDescending(bill => bill.Cost).ToList();
            SaveFileDialog save = new();
            save.FileName = "BudgetReport.txt";
            save.Filter = "Text File | *.txt";
            DateTime dateTime = DateTime.Now;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new(save.OpenFile());
                writer.WriteLine("BUDGET REPORT - " + dateTime);
                writer.WriteLine(rtbAllExpenses.Text);
                writer.Dispose();
                writer.Close();
            }
            
        }

        //Opens frmMain again.
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }
    }
}
