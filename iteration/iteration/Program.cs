using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

        //iterating through an array

        // int loop


        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
        //iterate through the list
        for (int i = 0; i < testScores.Length; i++)  // i is currently equal to 0, as long as i is less than test scores length it will iterate, at the end of each loop +1 is added to i
        {
            if (testScores[i] >= 85) // if the test score currently stored in i is equal to or greater than 85
            {
                Console.Write("Passing test score: " + testScores[i] + "\n"); // print the passing test score and add a new line
            }
            else // otherwise
            {
                Console.Write("Failing test score: " + testScores[i] + "\n"); // print the failing test score and add a new line
            }
        } //end the for loop

        Console.Write("\n");

        //string loop

        string[] names = { "Amber", "Matt", "Deku", "Jazz", "Sweet Pea", "Trixie", "Leo"};

        for (int i = 0; i < names.Length; i++) // i starts at index 0, as long as i is less than the number of names run through the loop, at the end of each loop add 1 to i
        {
            if (names[i] == "Amber" || names[i] == "Matt") // if the name in i is equal to either of these selections
            {
                Console.Write(names[i] + " is a human\n"); // write this to the console
            }
            else if (names[i] == "Deku") // otherwise if the name is equal to this
            {
                Console.Write(names[i] + " is a dog\n"); // write this to the console
            }
            else // if neither of the above are true
            {
                Console.Write(names[i] + " is a cat\n"); //write this to the console
            }
        }

        Console.Write("\n");

        // parse through and write an entire list to the console


        string[] animals = {"Deku", "Jazz", "Sweet Pea", "Trixie", "Leo" };

        for (int i = 0; i < animals.Length; i++) // i starts at index 0, as long as i is less than the number of animals run through the loop, at the end of each loop add 1 to i
         {
             Console.Write(animals[i] + "\n"); // write this to the console
         }

        Console.Write("\n");

        //iterating through a list

        //integer list

        List<int> moreTestScores = new List<int>(); // create a new integer list
        moreTestScores.Add(98); // adds to the list
        moreTestScores.Add(99);
        moreTestScores.Add(81);
        moreTestScores.Add(72);
        moreTestScores.Add(70);

        foreach (int score in moreTestScores) // for each index(int) that we are assigning to score from the moreTestScores list
        {
            if (score >= 85) // if the test score currently stored in score is equal to or greater than 85
            {
                Console.Write("Passing test score: " + score + "\n"); // print the passing test score and add a new line
            }
            else // otherwise
            {
                Console.Write("Failing test score: " + score + "\n"); // print the failing test score and add a new line
            }
        }

        Console.Write("\n");

        // string list

        List<string> moreNames = new List<string>(); // create a new string list
        moreNames.Add("Amber"); // adds to the list
        moreNames.Add("Matt");
        moreNames.Add("Deku");
        moreNames.Add("Trixie");
        moreNames.Add("Leo");
        moreNames.Add("Sweet Pea");
        moreNames.Add("Jazz");

        foreach (string animal in moreNames) // for each index(string) that we are assigning to animal from the moreNames list
        {
            if (animal == "Deku") // if the name current stored in animal is equal to Deku
            {
                Console.Write(animal + " is a dog.\n"); // print this to the console
            }
            else // otherwise
            {
                Console.Write(animal +  " is not a dog\n"); // print the following statement to the console
            }
        }
        Console.Write("\n");

        // iterates through the list and prints each name

        foreach (string animal in moreNames) // for each index(string) that we are assigning to animal from the moreNames list
        {
            Console.Write(animal + "\n"); // write this to the console
        }

        Console.Write("\n");

        //iterate through a list and then add to another list

        List<int> evenMoreTestScores = new List<int>() { 98, 99, 12, 74, 23, 99 }; // a way to create a list with data as it is created so each piece isn't added with the .Add
        List<int> passingScores = new List<int>(); // create an empty list for passing scores to be stored
        List<int> failingScores = new List<int>(); // create an empty list for failing scores to be stored

        foreach (int score in evenMoreTestScores) // for each score in the list
        {
            if (score >= 85) // if the score is greater than or equal to
            {
                passingScores.Add(score); // add to the passing scores list
            }
            else // otherwise
            {
                failingScores.Add(score); // add to the failing scores list
            }
            
        }

        foreach (int passing in passingScores) // for each index(string) that we are assigning to passing from the passingScores list
        {
            Console.Write("Passing Score: " + passing + "\n"); // write this to the console
        }
        foreach (int failing in failingScores) // for each index(string) that we are assigning to failing from the falingScores list
        {
            Console.Write("Failing Score: " + failing + "\n"); // write this to the console
        }

         Console.ReadLine();
                
        }
    }

