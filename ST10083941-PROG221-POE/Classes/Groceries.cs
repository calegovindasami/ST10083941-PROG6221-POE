using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Groceries : Expenses
    {
        public override string CostMessage()
        {
            return $"Groceries: R{arrExpenses[MTHLY_GROCERIES]}";
        }

        public override double GetCost()
        {
            return arrExpenses[MTHLY_GROCERIES];
        }

        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_GROCERIES] = cost;
        }
    }
}
