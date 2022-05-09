using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Utility : Expenses
    {
        public override string CostMessage()
        {
            return $"Water and lights: R{arrExpenses[MTHLY_UTILITIES]}";
        }

        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_UTILITIES] = cost;
        }

        public override double GetCost()
        {
            return arrExpenses[MTHLY_UTILITIES];
        }
    }
}
