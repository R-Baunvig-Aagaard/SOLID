namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            { 
                new PersonModel { Firstname = "Tim", Lastname = "Jensen"},
                new PersonModel { Firstname = "Bo", Lastname = "Nielsen"},
                new PersonModel { Firstname = "Kim", Lastname = "Andersen"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            
            
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));     
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Firstname}{emp.Lastname}:{emp.EmailAddress} Is Manager: {emp.IsManager}");

            }
        }
    }
}