using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class HomeLoan : Expenses
    {
        //Cost message of the corresponding expense.
        public override string CostMessage()
        {
            return $"Home loan: R{arrExpenses[MTHLY_ACCOMODATION]}";
        }

        //Sets the corresponding expense to the correct array position.
        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_ACCOMODATION] = cost;
        }

        //Calculates the monthly cost of the home loan.
        public double CalculateCost(double propertyPrice, double totalDeposit, double interestRate, int monthsToRepay)
        {
            double loanAmount = propertyPrice - totalDeposit;
            double interest = interestRate / 100;
            double monthlyCost = ((loanAmount * (interest / 12)) * (Math.Pow(1 + (interest / 12), monthsToRepay))) / (Math.Pow(1 + (interest / 12), monthsToRepay) - 1);
            return Math.Round(monthlyCost, 2);
        }

        //Returns the cost of the corresponding expense.
        public override double GetCost()
        {
            return arrExpenses[MTHLY_ACCOMODATION];
        }
    }
}
