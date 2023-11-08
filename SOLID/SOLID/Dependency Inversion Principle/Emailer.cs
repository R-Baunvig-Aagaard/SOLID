using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    public class Emailer
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulate sending an email to {person.EmailAddress}");
        }
    }
}
