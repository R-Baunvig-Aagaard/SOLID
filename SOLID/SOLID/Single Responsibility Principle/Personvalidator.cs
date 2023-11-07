using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class Personvalidator
    {
        public static bool Validate(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.Firstname))
            {
                Console.WriteLine("Not a valid first name");
                Console.ReadLine();
                return false;
            }
            if (string.IsNullOrWhiteSpace(user.Lastname))
            {
                Console.WriteLine("Not a valid last name");
                Console.ReadLine();
                return false;
            }

            return true;
        }
    }
}
