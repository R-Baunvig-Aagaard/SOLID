using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Employee Manager { get; set; } = null;

        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            //Do stuff
            Manager = manager;
        }

        public virtual void CalculateHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }
}
