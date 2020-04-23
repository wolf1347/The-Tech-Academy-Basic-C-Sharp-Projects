using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class CakeTools
    {
        public void createFrosting(bool color)
        {
            if (!color)
            {
                throw new Exception("Bad color choice");
            }
        }

        public void createBatter(bool type)
        {
            if (!type)
            {
                throw new Exception("Bad batter choice");
            }
        }

        public void createDecoration(bool decor)
        {
            if (!decor)
            {
                throw new Exception("Bad decoration choice");
            }
        }
    }
}
