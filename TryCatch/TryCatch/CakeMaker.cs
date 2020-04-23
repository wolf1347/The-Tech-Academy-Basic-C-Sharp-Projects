using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class CakeMaker
    {
        public void makeCake(bool color, bool batterType, bool decorType)
        {
            CakeTools cakeTools = new CakeTools();

            try
            {
                cakeTools.createBatter(batterType);
                cakeTools.createFrosting(color);
                cakeTools.createDecoration(decorType);

            }catch(Exception ex)
            {
                throw new Exception("Error making cake: " + ex.Message);
            }
        }

        public void makeBundtCake(bool color, bool batterType, bool decorType)
        {
            CakeTools cakeTools = new CakeTools();

            try
            {
                validateInput(color);
                cakeTools.createBatter(batterType);
                cakeTools.createFrosting(color);
                cakeTools.createDecoration(decorType);

            }
            catch (Exception ex)
            {
                throw new Exception("Error making BUNDT cake: " + ex.Message);
            }
        }



    }
}
