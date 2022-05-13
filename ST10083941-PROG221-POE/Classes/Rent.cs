using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Rent : Expenses
    {
        //Cost message of the corresponding expense.
        public override string CostMessage()
        {
            return $"Rent: R{arrExpenses[MTHLY_ACCOMODATION]}";
        }

        //Sets the corresponding expense to the correct array position.
        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_ACCOMODATION] = cost;
        }

        //Returns the cost of the corresponding expense.
        public override double GetCost()
        {
            return arrExpenses[MTHLY_ACCOMODATION];
        }
    }
}
