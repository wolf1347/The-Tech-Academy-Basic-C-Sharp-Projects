    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Fraud : Exception
    {

        public Fraud()
            : base() { }
        public Fraud(string message)
            : base(message) { }


    }
}
