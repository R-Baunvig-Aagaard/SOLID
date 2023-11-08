namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Tom",
                LastName = "Jensen",
                EmailAddress = "Tom-jensen@mail.com",
                PhoneNumber = "1234567890"
            };

            Chore chore = new Chore
            {
                ChoreName = "Homework",
                Owner = owner
            };

            chore.PerformedWork(4);
            chore.PerformedWork(1.5);
            chore.CompleteChore();


        }
    }
}