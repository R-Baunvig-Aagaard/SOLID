using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculateHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount + rank;
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
