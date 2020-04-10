using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {                       
        
        //arrays
        
        // need to define the array length before you can start it
        int[] numArray = new int[5]; //to create the array you need to instatiate it
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;
        Console.WriteLine(numArray[3]);


        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //another method for creating arrays. Cleaner than the above.
        Console.WriteLine(numArray1[4]);

        int[] numArray2 = { 5, 2, 10, 200, 5000 }; // this method allows you to leave out the new int. c# is able to assume you are instantiating a new array.
        Console.WriteLine(numArray2[0]);

        numArray2[4] = 650;
        Console.WriteLine(numArray2[4]);

        //lists

        List<int> intList = new List<int>();
        intList.Add(4); // add to a list
        intList.Add(10);
        intList.Add(5);
        intList.Add(18);
        intList.Add(12);
        intList.Remove(10); // remove from a list

        foreach (int i in intList) // allows you to parse through the list and print each item
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(intList[0]);


        Console.ReadLine();
    }
    }
