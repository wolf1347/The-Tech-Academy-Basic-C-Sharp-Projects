using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AND:");
            Console.WriteLine("TRUE && FALSE:");
            Console.WriteLine(true && false); // AND
            Console.WriteLine("TRUE && TRUE:");
            Console.WriteLine(true && true);
            Console.WriteLine("FALSE && FALSE:");
            Console.WriteLine(false && false);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("OR:");
            Console.WriteLine("TRUE || FALSE:");
            Console.WriteLine(true || false); // OR
            Console.WriteLine("TRUE || TRUE:");
            Console.WriteLine(true || true);
            Console.WriteLine("FALSE || FALSE:");
            Console.WriteLine(false || false);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("EQUAL:");
            Console.WriteLine("TRUE == FALSE:");
            Console.WriteLine(true == false); // EQUAL
            Console.WriteLine("TRUE == TRUE:");
            Console.WriteLine(true == true);
            Console.WriteLine("FALSE == FALSE:");
            Console.WriteLine(false == false);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("DOES NOT EQUAL:");
            Console.WriteLine("TRUE != FALSE:");
            Console.WriteLine(true != false); // DOES NOT EQUAL
            Console.WriteLine("TRUE != TRUE:");
            Console.WriteLine(true != true);
            Console.WriteLine("FALSE != FALSE:");
            Console.WriteLine(false != false);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("EXCLUSIVE OR:");
            Console.WriteLine("TRUE ^ FALSE:");
            Console.WriteLine(true ^ false); // EXCLUSIVE OR aka XOR
            Console.WriteLine("TRUE ^ TRUE:"); // Evaluates the true- it is exclusively one or the other. Not both. so true and true would be false. 
            Console.WriteLine(true ^ true);
            Console.WriteLine("FALSE ^ FALSE:");
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
