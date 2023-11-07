using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class CEOModel : IApplicantModel
    {
        public string Firstname { get ; set ; }
        public string Lastname { get ; set ; }
        public IAccounts AccountProcessor { get; set; } = new CEOAccount();
    }
}
