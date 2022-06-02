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
    public partial class frmMain : Form
    {
        //Objects of each expense is created globally so the same instance can be referenced in multiple methods.
        List<Expenses> expense = new() 
        {
            new Groceries("Groceries"),
            new HomeLoan("Home Loan"),
            new Other("Other Costs"),
            new PhoneBill("Phone Bill"),
            new Rent("Rent"),
            new Tax("Tax Deduction"),
            new Travel("Travel Costs"),
            new Utility("Utility Costs")
        };

        const int GROCERIES = 0;
        const int HOMELOAN = 1;
        const int OTHER = 2;
        const int PHONEBILL = 3;
        const int RENT = 4;
        const int TAX = 5;
        const int TRAVEL = 6;
        const int UTILITY = 7;

        //Variable to track whether or not the user is renting or purchasing a property.
        bool bRenting;
        public frmMain()
        {
            InitializeComponent();
            
            //Removes NumericUpDown controls on form launch.
            RemoveNumericUpDownControls(nudIncome);
            RemoveNumericUpDownControls(nudTax);
        }

        //Method created to remove the passed in NumericUpDown components arrows/controls 

        //----- Code Attribution -----
        //Website: StackOverFlow
        //Author: user3750325 (https://stackoverflow.com/users/3750325/user3750325)
        //Title: How to hide arrows on numericupdown controls in winforms.
        //Link: https://stackoverflow.com/questions/29450844/how-to-hide-arrows-on-numericupdown-control-in-win-forms
        public void RemoveNumericUpDownControls (NumericUpDown nud)
        {
            nud.Controls[0].Visible = false;
        }

        //----- End of Code Attribution -----

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            //Creates object of the monthly expense form and displays it until the user closes the form.
            frmExpenses frmExpenses = new();
            this.Hide();
            frmExpenses.ShowDialog();
            this.Show();

            //Sets the monthly expenses values from the input entered within the expense form.
            expense[GROCERIES].SetCost(frmExpenses.Groceries);
            expense[UTILITY].SetCost(frmExpenses.Utilities);
            expense[TRAVEL].SetCost(frmExpenses.Travel);
            expense[PHONEBILL].SetCost(frmExpenses.PhoneBill);
            expense[OTHER].SetCost(frmExpenses.Other);

            //Displays the monthly expenses within the monthly expense rich text box.
            string monthlyExpenses =
                expense[GROCERIES].Message() + "\n" +
                expense[UTILITY].Message() + "\n" +
                expense[TRAVEL].Message() + "\n" +
                expense[PHONEBILL].Message() + "\n" +
                expense[OTHER].Message() + "\n"
                ;

            rtbExpenses.Text = "COST OF EXPENSES PER MONTH:" + "\n" +  monthlyExpenses + "This worked";
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            //Sets the user renting to false and creates object of the home loan/mortgage form.
            bRenting = false;
            frmHomeLoan frmHomeLoan = new();
            this.Hide();
            frmHomeLoan.ShowDialog();
            this.Show();

            //Assigns the input home loan details to values then uses it to instantiate an object using the
            //variables as parameters.
            double propertyPrice = frmHomeLoan.PropertyPrice;
            double totalDeposit = frmHomeLoan.TotalDeposit;
            double interest = frmHomeLoan.InterestRate;
            int monthsToRepay = frmHomeLoan.MonthsToRepay;
            double monthlyLoanCost = homeLoan.CalculateCost(propertyPrice, totalDeposit, interest, monthsToRepay);
            homeLoan.SetCost(monthlyLoanCost);

            //Displays the monthly home loan cost.
            rtbAccommodation.Text = "COST OF ACCOMMODATION PER MONTH:" + "\n" + homeLoan.CostMessage();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            //Sets the renting variable to true and opens the form for the user to input their monthly rental cost.
            bRenting = true;
            frmRent frmRent = new();
            this.Hide();
            frmRent.ShowDialog();
            this.Show();

            //Assigns the input in form to the rent object value.
            rent.SetCost(frmRent.Rent);

            //Displays the monthly rental cost.
            rtbAccommodation.Text = "COST OF ACCOMMODATION PER MONTH:" + "\n" + rent.CostMessage();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Sets the income and tax deduction to the corresponding object.
            double monthlyIncome = Convert.ToDouble(nudIncome.Value);
            tax.SetCost(Convert.ToDouble(nudTax.Value));

            //Calculates the available income not including renting/home loan
            double availableIncome = monthlyIncome - (groceries.GetCost() + other.GetCost() + phoneBill.GetCost() + 
               tax.GetCost() + travel.GetCost() + utility.GetCost() );

            //Calculates the available income after all expenses are paid and whether they rent or have a home loan.
            if (bRenting == true)
            {
                availableIncome -= rent.GetCost();
            }
            else
            {
                availableIncome -= homeLoan.GetCost();
            }

            //String which displays all the expenses as well as a warning if their home loan repayment is more than 
            //1/3 of their income.
            string intro = "BUDGET REPORT\n";
  
            double totalMontlyExpenses = groceries.GetCost() + utility.GetCost() + travel.GetCost() + phoneBill.GetCost() + other.GetCost();

            string monthlyExpenses = $"Tax: R{tax.GetCost()}" + "\n" + $"Total Monthly Expenses: R{totalMontlyExpenses}\n";

            string accommodation;

            if (bRenting == true)
            {
                accommodation = rent.CostMessage() + "\n";
            }
            else
            {
                if (homeLoan.GetCost() > (monthlyIncome/3))
                {
                    accommodation = homeLoan.CostMessage() + "\n" + "CHANCE OF LOAN APPROVAL UNLIKELY." + "\n";
                }
                else
                {
                    accommodation = homeLoan.CostMessage() + "\n";
                }
            }
            availableIncome = Math.Round(availableIncome, 2);

            string end = $"YOUR MONTHLY AVAILABLE INCOME: R{availableIncome}";

            string message = intro + monthlyExpenses + accommodation + end;

            rtbReport.Text = message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets all the values of the fields within the form.
            nudIncome.Value = 0;
            nudTax.Value = 0;
            rtbExpenses.Clear();
            rtbAccommodation.Clear();
            rtbReport.Clear();
        }

    }
}
