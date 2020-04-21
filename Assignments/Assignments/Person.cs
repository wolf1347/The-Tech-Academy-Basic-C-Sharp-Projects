using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Person
    {
        public string FirstName { get; set; } // string for setting and getting a First Name
        public string LastName { get; set; } // string for setting and getting a Last Name

        public void SayName() //function to call on the name
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Write to the console what is set in to first name and last name
        }
    }
}
