using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeMaker cakeMaker = new CakeMaker();

            try
            {
                cakeMaker.makeCake(true, true, true);
                cakeMaker.makeBundtCake(true, true, true);
                Console.WriteLine("Successfully made cake!");

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
        }
    }
}
