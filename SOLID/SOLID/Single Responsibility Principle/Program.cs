namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();

            Person user = new Person();

            Console.Write("What is your first name: ");
            user.Firstname = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.Lastname = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(user.Firstname)) 
            {
                Console.WriteLine("Not a valid first name");
                Console.ReadLine();
                return;
            }
            if (string.IsNullOrWhiteSpace(user.Lastname))
            {
                Console.WriteLine("Not a valid last name");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($" Your username is {user.Firstname.Substring(0, 1)}{user.Lastname}");


        }
    }
}