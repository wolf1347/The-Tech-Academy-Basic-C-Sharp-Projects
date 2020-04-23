using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////********** Assignment Page 176 COMMENTED OUT**********//

            //Employee employee = new Employee();
            //employee.FirstName = "Sample"; 
            //employee.LastName = "Student";
            //employee.SayName();
            //Console.ReadLine();

            //********** Assignment Page 179 COMMENTED OUT**********//


            //Employee employee = new Employee(); // calls on the Employee class which will be called employee
            //employee.FirstName = "Sample"; // sets First Name to Sample
            //employee.LastName = "Student"; // sets Last Name to Student
            //employee.Quit(employee); // calls on the Quit method in Employee which was inherited via the IQuittable interface. Typically Employee would only be able to inherit one class, currently set to Person, but
            ////using the interface allows it to inherit from IQuittable as well and take the Quit function.
            //Console.ReadLine();


            ////********** Assignment Page 184 COMMENTED OUT**********//

            //var employee1 = new Employee {FirstName="Amber", LastName="Wolf", Id=01 }; // instantiate the Employee class in to employee1
            //var employee2 = new Employee {FirstName = "Deku", LastName = "Wolf", Id = 02 }; // instantiate the Employee class in to employee1

            //List<Employee> employeeList = new List<Employee>() // initialize a list and add the new instances of Employee in to it
            //{
            //   employee1,
            //   employee2
            //};


            //if (employee1 == employee2) // compare statement using the overload ==
            //{

            //}


            //Console.ReadLine();

            ////********** Assignment Page 187 COMMENTED OUT**********//

            ////class GenericEmployee<T> // creates generic class
            //GenericEmployee<string> employee = new GenericEmployee<string>(); // initialize the class as a string
            //GenericEmployee <int> employee2 = new GenericEmployee<int>(); // initialize the class as an intiger

            //List<string> blah = new List<string>();
            //blah.Add("Deku");
            //blah.Add("Leo");
            //blah.Add("Trixie");
            //blah.Add("Jazz");
            //blah.Add("Sweet Pea");

            //employee.Things = blah;

            //List<int> blah2 = new List<int>();
            //blah2.Add(1);
            //blah2.Add(2);
            //blah2.Add(3);
            //blah2.Add(4);
            //blah2.Add(5);

            //employee2.Things = blah2;

            //List<IEmployee> employeeList = new List<IEmployee>();
            //employeeList.Add(employee);
            //employeeList.Add(employee2);

            //foreach (IEmployee empl in employeeList)
            //{
            //    empl.PrintList();
            //}

            //Console.ReadLine();

            //********** Assignment Page 192 **********//

            Console.WriteLine("Please enter a day of the week");
            try
            {
                string dayEntered = Console.ReadLine();
                bool doesMatch = false;
                foreach (string d in Enum.GetNames(typeof(DayOfTheWeek)))
                {
                    if (dayEntered.Equals(d))
                    {
                        Console.WriteLine("Thank you for your input.");
                        doesMatch = true;
                    }
                }
                if (doesMatch != true)
                {
                    throw new FormatException("Please enter a valid day of the week."); 
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
            finally {
                Console.ReadLine();
            }
        }
    }
}
