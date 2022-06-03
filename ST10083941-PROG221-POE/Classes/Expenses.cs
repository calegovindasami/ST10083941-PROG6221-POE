using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    abstract class Expenses
    {
        public string Name { get; protected set; }
        public double Cost { get; protected set; }

        //Method to set the value of each monthly expense.
        public void SetCost(double cost)
        {
            Cost = cost;
        }

        public Expenses(string name)
        {
            Name = name;
        }

        public string Message()
        {
            return $"{Name} : {Cost}";
        }


        //Global constants to identify the position of each expense within the array.
        public const int MTHLY_TAX = 0;
        public const int MTHLY_GROCERIES = 1;
        public const int MTHLY_UTILITIES = 2;
        public const int MTHLY_TRAVEL = 3;
        public const int MTHLY_PHONEBILL = 4;
        public const int MTHLY_OTHER = 5;
        public const int MTHLY_ACCOMODATION = 6;

        protected virtual double CalculateCost(double propertyPrice, double totalDeposit, double interestRate, int monthsToRepay)
        {
            double loanAmount = propertyPrice - totalDeposit;
            double interest = interestRate / 100;
            double monthlyCost = ((loanAmount * (interest / 12)) * (Math.Pow(1 + (interest / 12), monthsToRepay))) / (Math.Pow(1 + (interest / 12), monthsToRepay) - 1);
            return Math.Round(monthlyCost, 2);
        }
    }
}
