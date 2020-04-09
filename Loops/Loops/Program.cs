using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch statement

            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12; // when the variable number is equal to 12 bool will be true

            do // this makes sure the loop is done at least once. This means it will hit case 12- otherwise when you don't have the do statement and 12 is guessed first it will never initiate the while loop
            { // to return case 12. This ensures it happens at least once.
                switch (number)
                {
                    case 62: //if number is 62
                        Console.WriteLine("You guessed 62. Guess again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine()); // update the variable number to the new number
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuessed = true; // updates the isGuessed variable to true so the while loop stops
                        break;
                    default: // if none of the cases are correct this is the default
                        Console.WriteLine("That is incorrect. Guess again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }// end switch 
            }
            while (!isGuessed); // the !isguessed means the same as isGuessed=false. The while loop will run while isGuessed = not true. 
            Console.ReadLine();
        }
    }
}
