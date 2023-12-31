﻿namespace Open_Closed_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            { 
                new PersonModel { Firstname = "Tim", Lastname = "Jensen"},
                new ManagerModel { Firstname = "Bo", Lastname = "Nielsen"},
                new CEOModel { Firstname = "Kim", Lastname = "Andersen"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            
            
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));     
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Firstname}{emp.Lastname}:{emp.EmailAddress} Is Manager: {emp.IsManager} Is CEO: {emp.IsCEO}");

            }
        }
    }
}