using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Other : Expenses
    {
        public override string CostMessage()
        {
            return $"Other: R{arrExpenses[MTHLY_OTHER]}";
        }

        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_OTHER] = cost;
        }

        public override double GetCost()
        {
            return arrExpenses[MTHLY_OTHER];
        }
    }
}
