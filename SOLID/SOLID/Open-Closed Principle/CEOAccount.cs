using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class CEOAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.EmailAddress = $"{person.Firstname}{person.Lastname}@CEO-mail.com";

            output.IsManager = true;
            output.IsCEO = true;

            return output;
        }
    }
}
