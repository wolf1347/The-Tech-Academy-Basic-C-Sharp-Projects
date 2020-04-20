using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class MoreMath
    {
        public int equation(int number1, int number2)
        { // create function to add
            return number1 + number2;
        }

        public double equation(double number3, double number4) // double function that will take in doubles- which will allow it to return a decimal
        { // create function to divide. Same name as the previous function but it will be able to differentiate between which one to use.       
            return number3 / number4;
        }

        public int equation(string number5, string number6) // it is an int function but it will take in strings
        { // create function to multiply. Same name as the previous function but it will be able to differentiate between which one to use. 

            int num5 = Int32.Parse(number5); // convert to an integer and stores in num5
            int num6 = Int32.Parse(number6); // convert to an integer and stores in num6
            return num5 * num6; // multiplies and returns the result
        }
    }
}
