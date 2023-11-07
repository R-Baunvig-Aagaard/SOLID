using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.EmailAddress = $"{person.Firstname.Substring(0, 1)}{person.Lastname}@mail.com";

            return output;
        }
    }
}
