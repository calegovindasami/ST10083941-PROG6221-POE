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
        //List of each expense object
        List<Expenses> expense = new()
        {
            new Groceries("Groceries"),
            new HomeLoan("Home Loan"),
            new Other("Other Costs"),
            new PhoneBill("Phone Bill"),
            new Rent("Rent"),
            new Tax("Tax Deduction"),
            new Travel("Travel Costs"),
            new Utility("Utility Costs"),
            new Vehicle("Vehicle Cost")

        };

        //Constants to keep track of the position of each object within the list.
        const int GROCERIES = 0;
        const int HOMELOAN = 1;
        const int OTHER = 2;
        const int PHONEBILL = 3;
        const int RENT = 4;
        const int TAX = 5;
        const int TRAVEL = 6;
        const int UTILITY = 7;
        const int VEHICLE = 8;


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

            //Sets the monthly expenses values from the input entered within the derived classes.
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

            rtbExpenses.Text = "COST OF EXPENSES PER MONTH:" + "\n" +  monthlyExpenses;
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            //Sets the user renting to false and creates object of the home loan/mortgage form.
            bRenting = false;
            frmHomeLoan frmHomeLoan = new();
            this.Hide();
            frmHomeLoan.ShowDialog();
            this.Show();

            //Assigns the input home loan details to values then sets the properties of the homeloan class as the variables.
            double propertyPrice = frmHomeLoan.PropertyPrice;
            double totalDeposit = frmHomeLoan.TotalDeposit;
            double interest = frmHomeLoan.InterestRate;
            int monthsToRepay = frmHomeLoan.MonthsToRepay;
            double income = Convert.ToDouble(nudIncome.Value);

            HomeLoan homeLoan = (HomeLoan)expense[HOMELOAN];

            homeLoan.SetProperties(propertyPrice, totalDeposit, interest, monthsToRepay, income);

            double monthlyLoanCost = homeLoan.CalculateCost(HomeLoanAlert);
            expense[HOMELOAN].SetCost(Math.Round(monthlyLoanCost, 2));
            expense[RENT].SetCost(0);

            string message = $" HOME LOAN\n Property Price R{homeLoan.PropertyPrice}\n Total Deposit R{homeLoan.TotalDeposit}\n Interest Rate {homeLoan.InterestRate}%\n" +
                $" Months to Repay: {homeLoan.MonthsToRepay} months\n TOTAL MONTHLY COST: R{homeLoan.Cost}";

            //Displays the monthly home loan cost.
            rtbAccommodation.Text = message;
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
            expense[RENT].SetCost(frmRent.Rent);
            expense[HOMELOAN].SetCost(0);

            //Displays the monthly rental cost.
            rtbAccommodation.Text = "COST OF ACCOMMODATION PER MONTH:" + "\n" + expense[RENT].Message();
        }

        //Method to be called to alert the user that their expenses exceed 75% of their income.
        public void ExpenseAlert(double total)
        {
            double alertAmount = Convert.ToDouble(nudIncome.Value) * (0.75);

            if (total > alertAmount)
            {
                MessageBox.Show("Your monthly expenses exceed 75% of your monthly income!");
            }
        }

        //Opens the vehicle form, saves the data within the vehicle object and displays the data.
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmVehicle frmVehicle = new();
            this.Hide();
            frmVehicle.ShowDialog();
            this.Show();

            ((Vehicle)expense[VEHICLE]).SetProperties(frmVehicle.ModelMake, frmVehicle.PurchasePrice, frmVehicle.TotalDeposit,
                frmVehicle.InterestRate, frmVehicle.InsurancePremium);

            double monthlyCost = ((Vehicle)expense[VEHICLE]).CalculateRepayment();
            expense[VEHICLE].SetCost(Math.Round(monthlyCost, 2));

            Vehicle vehicle = (Vehicle)expense[VEHICLE];

            string message = $" VEHICLE LOAN\n Vehicle Model Make: {vehicle.ModelMake}\n Purchase Price: R{vehicle.PurchasePrice}\n Total Deposit: R{vehicle.TotalDeposit}\n" +
                $" Interest Rate: {vehicle.InterestRate}%\n Insurance Premium: R{vehicle.InsurancePremium}\n Total Monthly Cost: R{vehicle.Cost}";

            rtbVehicle.Text = message;


        }

        //Opens the report form and sends values through.
        private void btnReport_Click(object sender, EventArgs e)
        {
            double income = Convert.ToDouble(nudIncome.Value);
            expense[TAX].SetCost(Convert.ToDouble(nudTax.Value));
            frmReport frmReport = new(expense, income);
            this.Hide();
            frmReport.ShowDialog();
            this.Close();


        }

        //Method that alerts user when their homeloan exceeds 1/3 of their income.
        public void HomeLoanAlert(double loan)
        {
            double income = Convert.ToDouble(nudIncome.Value);
            if (loan > (income * 1/3))
            {
                MessageBox.Show("Warning! Your monthly home loan installment exceeds 1/3rd of your income.");
            }
        }

        //Sets the maximum value tax can be based on the income.
        private void nudIncome_ValueChanged(object sender, EventArgs e)
        {
            nudTax.Maximum = nudIncome.Value;
        }
        
        //Resets all components and objects.
        private void btnReset_Click(object sender, EventArgs e)
        {
            nudIncome.Value = 0;
            nudTax.Value = 0;
            rtbExpenses.Clear();
            rtbAccommodation.Clear();
            rtbVehicle.Clear();

            foreach (Expenses bill in expense)
            {
                bill.SetCost(0);
            }
        }
    }
}
