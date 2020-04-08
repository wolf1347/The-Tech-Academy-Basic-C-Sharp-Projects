using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //primary math operators

            int total = 10 + 5;
            int othertotal = 12 + 22;
            int combined = total + othertotal;
            Console.WriteLine("ten plus five is equal to " + total);
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("ten minus five is equal to " + difference);
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine("ten times five is equal to " + product);
            Console.ReadLine();

            int simpledivision = 10 / 5;
            Console.WriteLine("ten divided by five is equal to " + simpledivision);
            Console.ReadLine();

            int roundeddivision = 100 / 17;
            Console.WriteLine("one hundred divided by seventeen is equal to " + roundeddivision + " rounded down using the int data type");
            Console.ReadLine();

            double unroundeddivision = 100.0 / 17.0; // must include the decimal place since we are using double instead of int
            Console.WriteLine("one hundred divided by seventeen is equal to " + unroundeddivision + " unrounded using the double data type");
            Console.ReadLine();

            //remainders - to make it easy the % is used to denote a remainder.

            int remainder = 10 % 2;
            Console.WriteLine("ten divided by two has " + remainder + " left over");
            Console.ReadLine();

            int remainder2 = 11 % 2;
            Console.WriteLine("eleven divided by two has " + remainder2 + " left over");
            Console.ReadLine();

            //comparison operators-output a boolean.

            bool trueorfalse = 12 > 5;

            Console.WriteLine("12 is greater than 5: " + trueorfalse);
            Console.ReadLine();

            bool trueorfalse2 = 12 < 5;

            Console.WriteLine("12 is less than 5: " + trueorfalse2);
            Console.ReadLine();

            bool trueorfalse3 = 12 == 5;

            Console.WriteLine("12 is equal to 5: " + trueorfalse3);
            Console.ReadLine();

            int roomtemperature = 70;
            int currenttemperature = 70;
            bool iswarm = currenttemperature > roomtemperature; // greater than
            bool iscold = currenttemperature <= roomtemperature; //less than or equal to
            bool isalsocold = currenttemperature < roomtemperature; //less than
            bool isalsowarm = currenttemperature >= roomtemperature; //greater than or equal to
            bool isequal = currenttemperature == roomtemperature; // equal to

            Console.WriteLine(iswarm);
            Console.WriteLine(iscold);
            Console.WriteLine(isalsocold);
            Console.WriteLine(isalsowarm);
            Console.WriteLine(isequal);

            Console.ReadLine();
            if (currenttemperature >= roomtemperature)
            {

                Console.WriteLine("it is warm");
                Console.ReadLine();
            }   
            else
            {
                Console.WriteLine("it is cold");
                Console.ReadLine();
            }


        }
    }
}
