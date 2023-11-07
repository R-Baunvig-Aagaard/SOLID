using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class CEO : Employee
    {
        public override void CalculateHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount + rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("CEO has no manager");
        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Report of performance");
        }
        public void FireSomeone()
        {
            // Simulate someone being fired
            Console.WriteLine("You are fired");
        }
    }
}
