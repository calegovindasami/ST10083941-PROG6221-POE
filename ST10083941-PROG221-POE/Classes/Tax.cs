using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Tax : Expenses
    {
        public override string CostMessage()
        {
            return $"Tax: R{arrExpenses[MTHLY_TAX]}";
        }

        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_TAX] = cost;
        }

        public override double GetCost()
        {
            return arrExpenses[MTHLY_TAX];
        }
    }
}
