namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();

            Person user = PersonCapture.Capture();

            bool isUSerValid = Personvalidator.Validate(user);

            if (isUSerValid == false ) 
            {
                StandardMessage.EndMessage();
            }

          

            Console.WriteLine($" Your username is {user.Firstname.Substring(0, 1)}{user.Lastname}");

            StandardMessage.EndMessage();
        }
    }
}