using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Optional
    {
        public int optionalMath(int a, int? b=0)
        {
            int c = Convert.ToInt32(b);
            return a + c;
        }
    }
}
