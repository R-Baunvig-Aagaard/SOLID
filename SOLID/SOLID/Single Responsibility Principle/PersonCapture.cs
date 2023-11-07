using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class PersonCapture
    {
        public static Person Capture()
        {
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.Firstname = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.Lastname = Console.ReadLine();

            return user;
        }
    }
}
