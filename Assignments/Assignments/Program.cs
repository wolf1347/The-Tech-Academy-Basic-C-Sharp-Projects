using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static public void Main(string[] args)
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
            //string validatedAnimal = animal.ToUpper(); // forces the user input to be all caps. Allows the user to enter cat CAT or Cat and still get bool of true
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


            ////************ assignment page 136 COMMENTED OUT************//

            ////creating the string array

            //string[] stringArray = { "cat", "dog", "bird", "hamster", "lizard", "snake", "fish" }; // create a string array 


            //Console.WriteLine("Please select an index number from the string array starting with 0 and ending with 6"); // ask the user to make a selection
            //int stringSelection = Convert.ToInt32(Console.ReadLine()); // converts the selection from a string to an integer which allows it to be used in the print from the array
            //if (stringSelection <= 6) // if the user selection is 6 or less
            //{
            //    Console.WriteLine(stringArray[stringSelection]); // it will print from the array 
            //}
            //else // otherwise
            //{
            //    Console.WriteLine(stringSelection + " is not a valid selection."); // it tells the user it isn't a valid selection. 
            //}

            ////creating the int array

            //int[] intArray = { 5, 10, 15, 20, 25, 30, 35 }; // create an int array 

            //Console.WriteLine("Please select an index number from the integer array starting with 0 and ending with 6"); // ask the user to make a selection
            //int intSelection = Convert.ToInt32(Console.ReadLine()); // converts the selection from a string to an integer which allows it to be used in the print from the array

            //if (intSelection <= 6) // if the user selection is 6 or less
            //{
            //    Console.WriteLine(intArray[intSelection]);  // it will print from the array 
            //}
            //else // otherwise
            //{
            //    Console.WriteLine(intSelection + " is not a valid selection."); // it tells the user it isn't a valid selection. 
            //}

            //// creating the string list

            //List<string> stringList = new List<string>(); // creates a string list
            //stringList.Add("pizza");
            //stringList.Add("macaroni and cheese");
            //stringList.Add("nachos");
            //stringList.Add("grilled cheese");
            //stringList.Add("ramen");

            //Console.WriteLine("Please select an index number from the string list starting with 0 and ending with 4"); // ask the user to make a selection
            //int stringListSelection = Convert.ToInt32(Console.ReadLine());

            //if (stringListSelection <= 4) // if the user selection is 4 or less
            //{
            //    Console.WriteLine(stringList[stringListSelection]);  // it will print from the list 
            //}
            //else // otherwise
            //{
            //    Console.WriteLine(stringListSelection + " is not a valid selection."); // it tells the user it isn't a valid selection. 
            //}

            //Console.ReadLine();

            ////************ assignment page 142 COMMENTED OUT************//

            //string[] bestVideoGames = { "Mass Effect 2", "Animal Crossing New Leaf", "Overwatch", "Monster Rancher 2", "Earthbound", "Dark Cloud", "Pokemon Crystal Version", "Borderlands 2",
            //      "Deadly Premonition", "Ratchet and Clank a Crack in Time", "The Elder Scrolls: Oblivion", "Phoenix Wright Ace Attorney: Justice for All"}; // create a string array


            //Console.WriteLine("Array title is \"Best Video Games\". Please enter some text to add to an item in the array.");
            //string userArrayText = Console.ReadLine();

            //for (int i = 0; i < bestVideoGames.Length; i++)
            //{
            //    Console.Write(bestVideoGames[i] + " " + userArrayText + "\n");
            //}

            //Console.ReadLine();

            ////while (true)  // 
            ////{
            ////    Console.WriteLine("Hello"); //// commented out the infinite loop
            //// }
            ////Console.ReadLine();

            //bool infiniteLoop = true;

            //while (infiniteLoop)  // 
            //{
            //    Console.WriteLine("Hello"); // here is the infinite loop corrected to run once
            //    infiniteLoop = false;
            //}

            //Console.WriteLine("\n"); // adds a blank line for readablility

            //for (int i = 0; i < 10; i++) // while i is less than 10
            //{
            //    Console.WriteLine(i); // do this
            //}

            //Console.WriteLine("\n"); // adds a blank line for readablility

            //for (int i = 0; i <= 10; i++) // while i is less than or equal to 10
            //{
            //    Console.WriteLine(i); // do this
            //}

            //// list created with no duplicates

            //List<string> favoriteGames = new List<string>() {"Mass Effect 2", "Animal Crossing New Leaf", "Overwatch", "Monster Rancher 2", "Earthbound", "Dark Cloud", "Pokemon Crystal Version", "Borderlands 2",
            //      "Deadly Premonition", "Ratchet and Clank a Crack in Time", "The Elder Scrolls: Oblivion", "Phoenix Wright Ace Attorney: Justice for All"};

            //Console.WriteLine("Please search my list of favorite video games to see if you find a match."); // ask the user to search for a game
            //string userGameSearch = Console.ReadLine(); // assign their search to userGameSearch
            //int index = favoriteGames.FindIndex(a => a.Contains(userGameSearch)); // If the search is found it will assign that games index # in the list to index


            //foreach (string game in favoriteGames) // for each index in favoriteGames is referred to as game
            //{
            //    if (favoriteGames.Contains(userGameSearch)) // if user search is equal to a game in the list
            //    {
            //        Console.WriteLine(userGameSearch + " is one of my favorites too! The index number is " + index); // write this
            //        Console.ReadLine();
            //        if (favoriteGames.Contains(userGameSearch)) // Not sure if I used this one correctly- the intention is it will check if the favoriteGames list contains userGameSearch. And if it does, stop the code with a break.
            //        {
            //            break;
            //        }
            //    }
            //    else // otherwise
            //    {
            //        Console.WriteLine("Sorry, " + userGameSearch + " is not on my list."); // write this
            //        break; // ends this code
            //    }

            //} //end foreach

            //Console.WriteLine("\n"); // adds a blank line for readablility

            ////list with duplicates 

            //List<string> housePets = new List<string>() { "Deku", "Jazz", "Sweet Pea", "Leo", "Trixie", "Deku" };  //Deku is in here twice

            //Console.WriteLine("I have 5 pets. Deku, Jazz, Trixie, Sweet Pea, and Leo. Please select one to search the list for."); // ask the user to search for a game
            //string petSearch = Console.ReadLine(); // assign their search to petSearch
            //int pets = housePets.FindIndex(a => a.Contains(petSearch)); // If the search is found it will assign that games index # in the list to index


            //foreach (string pet in housePets) // for each index in favoriteGames is referred to as game
            //{
            //    if (housePets.Contains(petSearch)) // if user search is equal to a pet in the list
            //    {
            //        Console.WriteLine(petSearch + " " + pets); // write this //- when the list has duplicates it seems to stop at the first instance of finding "Deku"
            //        Console.ReadLine();
            //        break;
            //    }
            //    else // otherwise
            //    {
            //        Console.WriteLine("Sorry, " + petSearch + " is not one of my pets"); // write this
            //        break;
            //    }

            //}// end foreach

            //Console.WriteLine("\n"); // adds a blank line for readablility

            //// string list with duplicate search for dups

            //List<string> dinnerChoices = new List<string>() { "Tacos", "Ramen", "Breakfast for Dinner", "Soup and Salad", "Spaghetti", "Spaghetti" };  //Deku is in here twice
            //var dinner = dinnerChoices.GroupBy(i => i);
            //foreach (var food in dinner)
            //{
            //    Console.WriteLine("{0} {1}", food.Key, food.Count()); // counts the number of times this item is on the list. Since Spaghetti is on there twice the count will return 2 to indicate a duplicate
            //}

            //Console.ReadLine();

            ////************ assignment page 147 COMMENTED OUT************//

            //List<int> divideNumbers = new List<int>() { 75, 100, 250, 425 }; // intinger list


            //try // try to do the foreEach
            //{
            //    Console.WriteLine("Please enter a number to divide by a number on our list. The resulting number will be rounded"); // asks the user for a number
            //    int userNumber = Convert.ToInt32(Console.ReadLine()); // converts the user input to a int so it can be used in a math equation.

            //    foreach (int number in divideNumbers) // will loop through the list
            //    {
            //        int dividedNumber = number / userNumber; // divide the number on the list to the user's entered number and assigns it in divideNumber
            //        Console.WriteLine(number + " divided by " + userNumber + " is equal to " + dividedNumber); // prints this message to the screen to show the result
            //    }
            //}
            //catch (FormatException) // if there is a format exception
            //{
            //    Console.WriteLine("Please enter a number. Cannot divide a number by a string.\n"); // print this message
            //}
            //catch (DivideByZeroException) // if there is a divide by zero exception
            //{
            //    Console.WriteLine("Unable to divide by zero"); // print this message to the screen
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message); // otherwise print the standard generic message
            //}
            //finally // ensures this will always run
            //{
            //    Console.WriteLine("\nIf you can see this that means the finally has been hit after they try catch"); //write a message to show this still hits even after an exception in the try catch
            //    Console.ReadLine(); // ensures the Console.ReadLine is always hit
            //}

            ////************ assignment page 156 COMMENTED OUT************//

            //Math mathFunctions = new Math(); // calls on Math which can be called on by mathFunctions

            //Console.WriteLine("Please enter a number"); // ask the user for a number
            //int userNumber1 = Convert.ToInt32(Console.ReadLine()); // store that number
            //Console.WriteLine("Please enter a second number"); // ask for a second number
            //int userNumber2 = Convert.ToInt32(Console.ReadLine()); // store that number


            //int additionResult = mathFunctions.addition(userNumber1, userNumber2); // calls on the addition function in math
            //Console.WriteLine(userNumber1 + " + " + userNumber2 + " is equal to " + additionResult); // prints the results
            //Console.ReadLine();


            //Console.WriteLine("Please enter a number");
            //int userNumber3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a second number");
            //int userNumber4 = Convert.ToInt32(Console.ReadLine());


            //int subtractionResult = mathFunctions.subtraction(userNumber3, userNumber4); // calls on the subtraction function in math
            //Console.WriteLine(userNumber3 + " - " + userNumber4 + " is equal to " + subtractionResult); // prints the results
            //Console.ReadLine();

            //Console.WriteLine("Please enter a number");
            //int userNumber5 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a second number");
            //int userNumber6 = Convert.ToInt32(Console.ReadLine());


            //int multiplyResults = mathFunctions.multiplication(userNumber5, userNumber6); // calls on the multiplication function in math
            //Console.WriteLine(userNumber5 + " * " + userNumber6 + " is equal to " + multiplyResults); // prints the results
            //Console.ReadLine();

            ////************ assignment page 159 COMMENTED OUT************//

            //MoreMath moreMathFunctions = new MoreMath(); // calls on MoreMath which can be called on by moreMathFunctions

            //Console.WriteLine("Please enter a number"); // ask the user for a number
            //int userNumberA = Convert.ToInt32(Console.ReadLine()); // store that number
            //Console.WriteLine("Please enter a second number"); // ask for a second number
            //int userNumberB = Convert.ToInt32(Console.ReadLine()); // store that number

            //int divisionResult = moreMathFunctions.equation(userNumberA, userNumberB); // calls on the equation function in MoreMath passing through userNumberA and B
            //Console.WriteLine(userNumberA + " + " + userNumberB + " is equal to " + divisionResult); // prints the results
            //Console.ReadLine();

            //Console.WriteLine("Please enter a number"); // ask the user for a number
            //double userNumberC = Convert.ToDouble(Console.ReadLine()); // store that number
            //Console.WriteLine("Please enter a second number"); // ask for a second number
            //double userNumberD = Convert.ToDouble(Console.ReadLine()); // store that number

            //double decimalDivisionResult = moreMathFunctions.equation(userNumberC, userNumberD); // calls on the equation function in MoreMath passing through userNumberC and D
            //Console.WriteLine(userNumberC + " / " + userNumberD + " is equal to " + decimalDivisionResult); // prints the results
            //Console.ReadLine();

            //Console.WriteLine("Please enter a number"); // ask the user for a number
            //string userNumberE = Console.ReadLine(); // store that string- conversion will be done in the function
            //Console.WriteLine("Please enter a second number"); // ask for a second number
            //string userNumberF = Console.ReadLine(); // store that string-conversion will be done in the function

            //int stringResults = moreMathFunctions.equation(userNumberE, userNumberF); // calls on the equation function in MoreMath passing through userNumberE and F
            //Console.WriteLine(userNumberE + " * " + userNumberF + " is equal to " + stringResults); // prints the results
            //Console.ReadLine();

            ////************ assignment page 160  COMMENTED OUT************//

            //Optional optional = new Optional(); 

            //Console.WriteLine("Please enter a number"); 
            //int userA = Int32.Parse(Console.ReadLine()); 
            //int? userB = null; // declares userB but with no value

            //if (!userB.HasValue) // if userB is null it will do the below
            //{
            //    Console.WriteLine("Please enter a second number. This number is optional. If you don't want to enter a number hit enter to continue and the equation will detault to 0"); // ask for a second number
            //    userB = int.TryParse(Console.ReadLine(), out int i) ? i : new int?(); // user input to update userB
            //    if (userB >= 0) // if the entered amount is equal to or greater than 0
            //    {
            //        int optionalResult = optional.optionalMath(userA, userB); // it will call on the optionalMath class with the Optional function
            //        Console.WriteLine(userA + " + " + userB + " is equal to " + optionalResult); // and write the equation to the line
            //        Console.ReadLine();
            //    }
            //    else {
            //        int optionalResult = optional.optionalMath(userA); // otherwise if it is not equal to or greater than 0 it will only pass through the userA and not userB. The class gives userB a default of 0 which 
            //        //will be used instead.
            //        Console.WriteLine(userA + " + " + " 0 " + " is equal to " + optionalResult); // writes this to the console
            //        Console.ReadLine();
            //    }
            //}

            ////************ assignment page 161 ************//

            //VoidClass VoidClass = new VoidClass(); // calls on MoreMath which can be called on by moreMathFunctions

            //Console.WriteLine( "Please enter a number"); // ask the user for a number
            //int voidNumber1 = Convert.ToInt32(Console.ReadLine()); // store that number
            //Console.WriteLine("Please enter a second number"); // ask for a second number
            //int voidNumber2 = Convert.ToInt32(Console.ReadLine()); // store that number

            //VoidClass.returnNothing(voidNumber1, voidNumber2);

            //Console.ReadLine();

            //************ assignment page 164 ************//

            MathClass VoidDivide = new MathClass(); // calls on the MathClass assigned to VoidDivide
            Console.WriteLine("Please enter a number"); // ask the user for a number
            int num1 = Convert.ToInt32(Console.ReadLine()); // store that number


            VoidDivide.divideByTwo(num1); // passes the number to the function which will return the result

            MathClass.Numbers(out int firstNumber, out int secondNumber); 

            Console.WriteLine("\n" +firstNumber + " and " + secondNumber); 

            Console.WriteLine("\n" + "Multiplying the 2 selected numbers: " + MathClass.duplicateName(10, 15)); // passes the numbers to the function duplicateName. 
            Console.WriteLine("\n" + "Adding the 3 selected numbers: " + MathClass.duplicateName(2, 5, 30)); // passes the numbers to the function duplicateName. This includes a third parameter so it knows which one to use 

            Console.ReadLine();

            
        }
    }
}
   