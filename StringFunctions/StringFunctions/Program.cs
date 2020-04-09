using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            //escape sequences

            string fname = "Amber";
            string quote = fname + " said, \"Hello\" \n This will put the text on the next line \n \t this will tab the text \n \\ there should be one back slash"; // \ will be an escape character that allows you to use quotes in your string
            // \n will put text on a new line while \t will tab it over. \\ will allow you to use a \ in your string. @ ignores the \ escape sequence
            string atSymbol = @"this tells it that everything inside here is being used. No escape sequences so you can use \ without it ignoring the next line.";
            Console.WriteLine(quote);
            Console.WriteLine(atSymbol);

            bool trueOrFalseContains = fname.Contains("m"); // if the name contains an m it will come back as true
            bool trueOrFalseEndsWith = fname.EndsWith("r"); // if the name ends with r it will come back as true
            int length = fname.Length; // will assign the int length to the # of characters in fname
            fname = fname.ToUpper(); // forces the input to be all uppercase


            Console.WriteLine(trueOrFalseContains);
            Console.WriteLine(trueOrFalseEndsWith);
            Console.WriteLine(length);
            Console.WriteLine(fname);

            fname = fname.ToLower(); //forces the input to be all lowercase
            Console.WriteLine(fname); 

        

            //strings are immutable. Once created they can't change. It may appear like it changes but in memory a new string is created.

            string lname = "Wolf";
            lname = "Bear";
            Console.WriteLine(lname);

            //the output will show "Bear" instead of "Wolf". So, visually the lname has been changed in the computer's memory it actually hasn't. Normally this doesn't matter when you are working with a small
            //ammount of data but can cause slow downs with larger sets of data since every time you "change" it it has to create a new string in memory. 

            //string builder class is how you get around this

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Amber"); //apends the sb string with the input

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
