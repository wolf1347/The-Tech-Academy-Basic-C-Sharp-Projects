using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //using if else and else if statements

            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");         
            //}
            //else if (currentTemperature > roomTemperature)
            //    {
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //Console.ReadLine();

            ////does the same thing but in a single line of code using ? "what is the response when true" : "what is the response when false"

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temperature" : "It is not room temperature";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is room temperature where you are");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature where you are");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is cooler than room temperature where you are");
            //}
            //else
            //{
            //    Console.WriteLine("error 404 temperature not found");
            //}
            //Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            string results = favoriteNumber == 5 ? "Five is my favorite number too" : "I guess that is a good number but five is better";
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
