using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    public class Employee: Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee information \n");
            base.SayName();
        }
    }
}
