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

            AccountGenerator.CreateAccount(user);

            StandardMessage.EndMessage();
        }
    }
}