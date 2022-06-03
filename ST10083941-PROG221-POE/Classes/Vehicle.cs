using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    class Vehicle : Expenses
    {
        public string ModelMake { get; set; }
        public Vehicle(string name) : base(name)
        {

        }

        public double CalculateRepayment(double purchasePrice, double totalDeposit, double interestRate, double insurancePremium)
        {
            double loanAmount = purchasePrice - totalDeposit;
            double totalAmount = loanAmount * (interestRate / 100);
            double monthlyCost = totalAmount / 60;
            double totalExpenses = monthlyCost + insurancePremium;
            return totalExpenses;
        }
    }
}
