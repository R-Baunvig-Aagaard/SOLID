using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        
        public virtual void AssignManager(IEmployee manager)
        {
            //Do stuff
            Manager = manager;
        }

    }
}
