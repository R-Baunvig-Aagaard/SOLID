using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class StandardMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the application");
        }

        public static void EndMessage()
        {
            Console.WriteLine("End of Application");
        }
    }
}
