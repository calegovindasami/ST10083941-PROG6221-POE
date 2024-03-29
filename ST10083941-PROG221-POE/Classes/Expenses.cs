﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10083941_PROG221_POE.Classes
{
    abstract class Expenses
    {
        //Properties of all the derived classes using Expenses as a base class.
        public string Name { get; protected set; }
        public double Cost { get; protected set; }

        //Method to set the value of each monthly expense.
        public void SetCost(double cost)
        {
            Cost = cost;
        }

        //Sets the name for each expense using the constructor
        public Expenses(string name)
        {
            Name = name;
        }

        //Displays the derived classes costs and name.
        public string Message()
        {
            return $"{Name} : R{Cost}";
        }

    }
}
