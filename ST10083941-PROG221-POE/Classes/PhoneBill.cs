using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class PhoneBill : Expenses
    {
        //Cost message of the corresponding expense.
        public override string CostMessage()
        {
            return $"Cell phone and telephone: R{arrExpenses[MTHLY_PHONEBILL]}";
        }

        //Sets the corresponding expense to the correct array position.
        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_PHONEBILL] = cost;
        }

        //Returns the cost of the corresponding expense.
        public override double GetCost()
        {
            return arrExpenses[MTHLY_PHONEBILL];
        }
    }
}
