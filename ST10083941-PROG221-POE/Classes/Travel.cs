using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Travel : Expenses
    {
        public override string CostMessage()
        {
            return $"Travel: R{arrExpenses[MTHLY_TRAVEL]}";
        }

        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_TRAVEL] = cost;
        }

        public override double GetCost()
        {
            return arrExpenses[MTHLY_TRAVEL];
        }
    }
}
