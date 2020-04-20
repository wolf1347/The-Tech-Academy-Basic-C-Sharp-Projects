using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class VoidClass
    {

        public void returnNothing(int numA, int numB)
        {
            int math1 = numA + numB;
            int math2 = numA + 5;

            Console.WriteLine("numA is " + numA + "\n" +
                "numB is " + numB + "\n"
                + numA + " plus " + numB + " is equal to " + math1 + "\n"
                + numA + " plus " + "5" + " is equal to " + math2 + "\n");
            
        }
    }
}
