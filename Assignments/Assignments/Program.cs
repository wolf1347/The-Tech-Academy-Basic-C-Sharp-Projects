using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {

            //************ assignment page 101 ************//

            Console.WriteLine("What is your age?"); // ask the user age
            int personAge = Convert.ToInt32(Console.ReadLine()); // assign the user input to personAge

            Console.WriteLine("Have you ever had a DUI? Please answer with true or false"); // ask the user if they have had a dui
            bool personDUI = Convert.ToBoolean(Console.ReadLine()); // assign the user input to personDUI- since it is boolean it must be true or false

            Console.WriteLine("How many speeding tickets do you have?"); // ask the user number of tickets
            int personTickets = Convert.ToInt32(Console.ReadLine()); // assign the user input to personTickets

            if (personAge >= 15 && personTickets <= 3 && personDUI == false) //If statement to determine the output- the person age must be equal to or greater than 15 AND number of tickets must be equal to
            {                                                                  // or less than 3 AND DUI must be false.
                Console.WriteLine("Congratulations, you are eligible for car insurance"); //if all of these conditions are met the console will print this.
            }
            else // if the conditions are not met it will print this.
            {
                Console.WriteLine("Sorry, you are not eligible for car insurance");
            }

            Console.ReadLine();
        }
    }
}
   