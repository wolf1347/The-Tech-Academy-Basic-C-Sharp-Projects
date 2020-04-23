using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class GenericEmployee<T> : IEmployee // creates generic class
    {
        public List<T> Things { get; set; } // property of Things that will take any value "T"
        
        public void PrintList()
        {
            foreach (T empl in Things)
            {
                Console.WriteLine(empl);
            }
        }
    }
}
