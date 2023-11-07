using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class EmployeeModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }

        public bool IsManager { get; set; } = false;

        public bool IsCEO { get; set; } = false;
    }
}
