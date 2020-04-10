﻿using System;
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

            ////************ assignment page 101 COMMENTED OUT ************//

            //Console.WriteLine("What is your age?"); // ask the user age
            //int personAge = Convert.ToInt32(Console.ReadLine()); // assign the user input to personAge

            //Console.WriteLine("Have you ever had a DUI? Please answer with true or false"); // ask the user if they have had a dui
            //bool personDUI = Convert.ToBoolean(Console.ReadLine()); // assign the user input to personDUI- since it is boolean it must be true or false

            //Console.WriteLine("How many speeding tickets do you have?"); // ask the user number of tickets
            //int personTickets = Convert.ToInt32(Console.ReadLine()); // assign the user input to personTickets

            //if (personAge >= 15 && personTickets <= 3 && personDUI == false) //If statement to determine the output- the person age must be equal to or greater than 15 AND number of tickets must be equal to
            //{                                                                  // or less than 3 AND DUI must be false.
            //    Console.WriteLine("Congratulations, you are eligible for car insurance"); //if all of these conditions are met the console will print this.
            //}
            //else // if the conditions are not met it will print this.
            //{
            //    Console.WriteLine("Sorry, you are not eligible for car insurance");
            //}

            //Console.ReadLine();

            ////************ assignment page 123 COMMENTED OUT ************//

            //Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // intro line

            //Console.WriteLine(Environment.NewLine); //leaves a blank line between the next line

            //Console.WriteLine("What is the Weight of the package?"); // ask the user for the weight
            //double packageWeight = Convert.ToDouble(Console.ReadLine()); // allows the weight to be a decimal i.e 4.5lbs

            //if (packageWeight > 50) // if the package weight is greater than this
            //{
            //    Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day."); // end the program with this statement
            //}
            //else // if it is not greater than 50 do this
            //{
            //    Console.WriteLine("What is the Width of the package?"); // ask the width of the package
            //    double packageWidth = Convert.ToDouble(Console.ReadLine()); // allows the input to be a decimal

            //    Console.WriteLine("What is the Length of the package?"); // ask the length of the package
            //    double packageLength = Convert.ToDouble(Console.ReadLine()); // allows the input to be a decimal

            //    Console.WriteLine("What is the Height of the package?"); // ask the height of the package
            //    double packageHeight = Convert.ToDouble(Console.ReadLine()); // allows the input to be a decimal

            //    double boxDimensions = packageWidth * packageLength * packageHeight; // dimension of a box is L X W X H
            //    double estimatedPrice = boxDimensions * packageWeight / 100; // To get the price take the box dimension * by weight and then divide

            //    if (boxDimensions > 50) // If the result of boxDimensions is greater than this it will
            //    {
            //        Console.WriteLine("Your package is too big to be shipped via Package Express."); // stop the program and end with this message
            //    }
            //    else
            //    { // If it is not greater than 50
            //        Console.WriteLine("Your estimated total for shipping this package is: $" + estimatedPrice); // it will return the estimated total
            //    }

            //}
            //Console.ReadLine(); // Allows the console to keep the message displayed

            ////************ assignment page 126 COMMENTED OUT ************/////

            //Console.WriteLine("What is your favorite animal?");
            //string animal = Console.ReadLine();
            //string validatedAnimal= animal.ToUpper(); // forces the user input to be all caps. Allows the user to enter cat CAT or Cat and still get bool of true
            //bool isGuessed = validatedAnimal == "DOG" || validatedAnimal == "DOGS"; // when the variable number is equal to DOG or DOGS bool will be true

            //// The code as a while statement //
            //while (!isGuessed) // while isGuessed is false do the following
            //{
            //    switch (validatedAnimal)    
            //    {
            //        case "DOG": //if the user entry is dog
            //            Console.WriteLine("Dogs are my favorite too! Aren't they great?");
            //            isGuessed = true;
            //            break;

            //        case "DOGS": // if the user entry is dogs
            //            Console.WriteLine("Dogs are my favorite too! Aren't they great?");
            //            isGuessed = true;
            //            break;

            //        default: // if none of the cases are correct this is the default
            //            Console.WriteLine(animal + "s are pretty great! But I think another animal is better.");
            //            Console.WriteLine("Do you have another favorite animal?");
            //            animal = Console.ReadLine(); // allows user to update animal to a different input
            //            validatedAnimal = animal.ToUpper(); // validates the new input to be uppercase
            //            break;
            //    }
            //}


            //// The same code redone a do while statement //

            //do // ensures the loop happens at least once. 
            //{

            //    switch (validatedAnimal)
            //    {
            //        case "DOG":
            //            Console.WriteLine("Dogs are my favorite too! Aren't they great?");
            //            isGuessed = true;
            //            break;

            //        case "DOGS":
            //            Console.WriteLine("Dogs are my favorite too! Aren't they great?");
            //            isGuessed = true;
            //            break;

            //        default: // if none of the cases are correct this is the default
            //            Console.WriteLine(animal + "s are pretty great! But I think another animal is better.");
            //            Console.WriteLine("Do you have another favorite animal?");
            //            animal = Console.ReadLine();
            //            validatedAnimal = animal.ToUpper();
            //            break;
            //    }

            //}
            //while (!isGuessed);

            //Console.ReadLine();

            ////************ assignment page 131 COMMENTED OUT************//

            ////Concatenate strings

            ////method 1 assigning the strings to a variable
            //string string1 = "I have a dog ";
            //string string2 = "his nme is Deku ";
            //string string3 = "and he is a Finnish Spitz.";

            //Console.WriteLine(string1 + string2 + string3);

            ////method 2 is just to add the strings together in the console.writeline without assigning them

            //Console.WriteLine("I also have a cat " + "his name is Jazz " + "and he is a Maine Coon");

            //// to uppercase

            //string1 = string1.ToUpper();
            //Console.WriteLine(string1);

            ////string builder

            //StringBuilder animals = new StringBuilder();
            //animals.Append("I have a dog "); //appends the string
            //Console.WriteLine(animals); // will write with only one line that has been added
            //animals.Append("his name is deku"); // appends the string
            //Console.WriteLine(animals); // will now write both lines that have been added
            //animals.Append(" and he is a finnish spitz."); // appends the string
            //Console.WriteLine(animals); // will now write 3 lines that have been added


            //************ assignment page 136************//

            // creating the string array

            string[] stringArray = { "cat", "dog", "bird", "hamster", "lizard", "snake", "fish" }; // create a string array 


            Console.WriteLine("Please select an index number from the string array starting with 0 and ending with 6"); // ask the user to make a selection
            int stringSelection = Convert.ToInt32(Console.ReadLine()); // converts the selection from a string to an integer which allows it to be used in the print from the array
            if (stringSelection <= 6) // if the user selection is 6 or less
            {
                Console.WriteLine(stringArray[stringSelection]); // it will print from the array 
            }
            else // otherwise
            {
                Console.WriteLine(stringSelection + " is not a valid selection."); // it tells the user it isn't a valid selection. 
            }

            //creating the int array

            int[] intArray = { 5, 10, 15, 20, 25 , 30, 35 }; // create an int array 

            Console.WriteLine("Please select an index number from the integer array starting with 0 and ending with 6"); // ask the user to make a selection
            int intSelection = Convert.ToInt32(Console.ReadLine()); // converts the selection from a string to an integer which allows it to be used in the print from the array

            if (intSelection <= 6) // if the user selection is 6 or less
            {
                Console.WriteLine(intArray[intSelection]);  // it will print from the array 
            }
            else // otherwise
            {
                Console.WriteLine(intSelection + " is not a valid selection."); // it tells the user it isn't a valid selection. 
            }

            // creating the string list

            List<string> stringList = new List<string>(); // creates a string list
            stringList.Add("pizza");
            stringList.Add("macaroni and cheese");
            stringList.Add("nachos");
            stringList.Add("grilled cheese");
            stringList.Add("ramen");

            Console.WriteLine("Please select an index number from the string list starting with 0 and ending with 4"); // ask the user to make a selection
            int stringListSelection = Convert.ToInt32(Console.ReadLine());

            if (stringListSelection <= 4) // if the user selection is 4 or less
            {
                Console.WriteLine(stringList[stringListSelection]);  // it will print from the list 
            }
            else // otherwise
            {
                Console.WriteLine(stringListSelection + " is not a valid selection."); // it tells the user it isn't a valid selection. 
            }

            Console.ReadLine();
        }
    }
}
   