using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class PhoneBill : Expenses
    {
        public override string CostMessage()
        {
            return $"Cell phone and telephone: R{arrExpenses[MTHLY_PHONEBILL]}";
        }

        public override void SetCost(double cost)
        {
            arrExpenses[MTHLY_PHONEBILL] = cost;
        }

        public override double GetCost()
        {
            return arrExpenses[MTHLY_PHONEBILL];
        }
    }
}
