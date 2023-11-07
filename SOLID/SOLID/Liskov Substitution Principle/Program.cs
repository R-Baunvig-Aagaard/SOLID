namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.Firstname = "Ras";
            accountingVP.Lastname = "Baunvig";
            accountingVP.CalculateHourRate(4);

            Employee emp = new Employee();

            emp.Firstname = "Tom";
            emp.Lastname = "Nielsen";
            emp.CalculateHourRate(2);

            Console.WriteLine($"{emp.Firstname} salary is: {emp.Salary} /hour.");
        }
    }
}