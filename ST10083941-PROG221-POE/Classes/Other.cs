using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Other : Expenses
    {
        //Cost message of the corresponding expense.
        public override string CostMessage()
        {
            return $"Other: R{arrExpenses[MTHLY_OTHER]}";
        }

        //Sets the corresponding expense to the correct array position.
        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_OTHER] = cost;
        }

        //Returns the cost of the corresponding expense.
        public override double GetCost()
        {
            return arrExpenses[MTHLY_OTHER];
        }
    }
}
