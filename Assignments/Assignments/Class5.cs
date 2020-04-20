using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class MathClass
    {

        public static int duplicateName(int a, int b) // overloading
        {
            return a * b;
        }

        public static int duplicateName(int a, int b, int c) //overloading- same name as the above but it takes in a 3rd parameter so when the compiler works it knows which method to use
        {
            return a + b + c;
        }

        public void divideByTwo(int numA) // void method that takes the users entered number and divides it by 2 then returns it
        {
            int divide = numA / 2;
            Console.WriteLine(numA + " / " + "2" + " = " + divide);
        }

        public static void Numbers(out int a, out int b) // method using out
        {
            a = 250;
            b = 500;
        }

        
    }
}
