using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    abstract class Expenses
    {
        //Method to set the value of each monthly expense.
        public abstract void SetCost(double cost);

        //Method to display value of each expense.
        public abstract string CostMessage();

        //Method to get the value of each monthly expense
        public abstract double GetCost();

        //Array to store the values for each expense in each class.
        protected double[] arrExpenses = new double[7];

        //Global constants to identify the position of each expense within the array.
        public const int MTHLY_TAX = 0;
        public const int MTHLY_GROCERIES = 1;
        public const int MTHLY_UTILITIES = 2;
        public const int MTHLY_TRAVEL = 3;
        public const int MTHLY_PHONEBILL = 4;
        public const int MTHLY_OTHER = 5;
        public const int MTHLY_ACCOMODATION = 6;
    }
}
