using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            //********** Assignment Page 192  COMMENTED OUT**********//

            //Console.WriteLine("Please enter a day of the week");
            //try
            //{
            //    string dayEntered = Console.ReadLine();
            //    bool doesMatch = false;
            //    foreach (string d in Enum.GetNames(typeof(DayOfTheWeek)))
            //    {
            //        if (dayEntered.Equals(d))
            //        {
            //            Console.WriteLine("Thank you for your input.");
            //            doesMatch = true;
            //        }
            //    }
            //    if (doesMatch != true)
            //    {
            //        throw new FormatException("Please enter a valid day of the week."); 
            //    }
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Error occured: " + ex.Message);
            //}
            //finally {
            //    Console.ReadLine();
            //}

            ////********** Assignment Page 197 **********//

            //Number number1 = new Number(); // initialize the Number struct in number1
            //Number number2 = number1; // reference the struct Number but instead of initializing a new Number it is set to number1

            //number1.Amount = 5.5M; //Set the Amount for number1
            //number2.Amount = 3.5M; //Set the Amount number2

            //Console.WriteLine(number1.Amount); //write to the console. This will be 5.5. Not influenced by number2 since it is a struct. If Number was a class instead of a Struct both outputs would be 3.5
            //Console.WriteLine(number2.Amount); //write to the console. This will be 3.5.
            //Console.ReadLine();

            ////********** Assignment Page 202 COMMENTED OUT**********//

            //Employee employee = new Employee(); // initialize Employee class
            //List<Employee> EmployeesList = new List<Employee>(); // create new Employee List
            //EmployeesList.Add(new Employee { FirstName = "Amber", LastName = "Wolf", Id = 01 }); // add a bunch of employees to the list
            //EmployeesList.Add(new Employee { FirstName = "Deku", LastName = "Dog", Id = 02 });
            //EmployeesList.Add(new Employee { FirstName = "Trixie", LastName = "Cat", Id = 03 });
            //EmployeesList.Add(new Employee { FirstName = "Leo", LastName = "Cat", Id = 04 });
            //EmployeesList.Add(new Employee { FirstName = "Jazz", LastName = "Cat", Id = 05 });
            //EmployeesList.Add(new Employee { FirstName = "Sweet Pea", LastName = "Cat", Id = 06 });
            //EmployeesList.Add(new Employee { FirstName = "Matthew", LastName = "Wells", Id = 07 });
            //EmployeesList.Add(new Employee { FirstName = "Joe", LastName = "Doesn't Exist", Id = 10 });
            //EmployeesList.Add(new Employee { FirstName = "Made Up", LastName = "Person", Id = 08 });
            //EmployeesList.Add(new Employee { FirstName = "Random", LastName = "Name", Id = 09 });
            //EmployeesList.Add(new Employee { FirstName = "Joe", LastName = "Two", Id = 11 });

            //int counter = 0; //counter for the for each loop

            //Console.WriteLine("\nPrinting all employees in the employee list\n");

            //List<Employee> JoeList = new List<Employee>(); //New list to store Joes

            //foreach (Employee empl in EmployeesList) // foreach loop to go through the employeelist
            //{ 
            //Console.WriteLine(empl.FirstName + " " + empl.LastName + " " + empl.Id); //writes out all of the employees
            //    if (empl.FirstName == "Joe") //if the first name is equal to Joe
            //    {
            //        JoeList.Add(new Employee { FirstName = empl.FirstName, LastName = empl.LastName, Id= empl.Id }); //add to the new JoeList
            //    }
            //    counter++; //increase the counter
            //}

            //Console.WriteLine("\nPrinting all employees added to the list of Joe's \n");
            //foreach (Employee joe in JoeList) //iterate through the JoeList
            //{
            //    Console.WriteLine(joe.FirstName + " " + joe.LastName + " " + joe.Id); //print to the console. This is to ensure that the foreach loop worked as intended and added both Joe's to the list
            //}

            //Console.WriteLine("\nPrinting all employees added to the list of Joe's using LAMBDA\n");

            //List<Employee> LAMBDAJoe = EmployeesList.Where( name => name.FirstName == "Joe").ToList(); //creating a new list called LAMBDAJoe from Employee list where the FirstName is equal to Joe- add to the list

            //foreach (Employee joe in LAMBDAJoe) // iterate through the LAMBDAJoe List
            //{
            //    Console.WriteLine(joe.FirstName + " " + joe.LastName + " " + joe.Id); //Write to the console
            //}

            //Console.ReadLine();

            ////********** Assignment Page 210 **********//

            //Console.WriteLine("Please enter a number"); //asks the user for a number
            //int userNumber = Convert.ToInt32(Console.ReadLine()); // converts it to an int

            //using (StreamWriter file = new StreamWriter(@"C:\The-Tech-Academy-Basic-C-Sharp-Projects\log.txt", true)) //add the path to the file that is set to append
            //{
            //    file.WriteLine(userNumber); // writes the users number to the file
            //}
            //Console.WriteLine("Thank you for entering a number. Your response has been logged.");
            //Console.ReadLine();

            ////********** Assignment Page 213  COMMENTED OUT**********//

            //DateTime currentTime = DateTime.Now; // sets the variable currentTime to whatever the current date and time is
            //Console.WriteLine("It is currently: " + currentTime); // writes the current time to the console
            //Console.WriteLine("Please enter a number of hours to add to this time"); // asks the user for a number
            //int userNumber = Convert.ToInt32(Console.ReadLine()); // converts this to an int
            //TimeSpan addHours = new TimeSpan(userNumber, 0, 0); // creates a new timespan with the users entered number in hours
            //DateTime futureTime = currentTime.Add(addHours); // takes the current time variable and adds the timespan hours to it
            //Console.WriteLine("In {0} hours it will be {1}", userNumber, futureTime); // write to the console the users selection and the results from adding it to the current time
            //Console.ReadLine();

            ////********** Assignment Page 221 COMMENTED OUT **********//

            //const string fName = "Amber"; // const string assigned to fName
            //var lName = "Wolf"; // var lName- don't declare that it is a string but when this variable is used it will be inferred that it is a string

            //Console.WriteLine("My name is {0} {1}", fName, lName); //write to the console


            //const int age = 28; //const int assigned to age
            //var year = 1; // var lName- don't declare that it is an int but when this variable is used it will be inferred that it is an int.
            //int bdayAge = age + year; //even though year wasn't declared as an int it can still be added to the constant int age.
            //Console.WriteLine("Right now I am {0} years old but turn {1} this year", age, bdayAge); //write to the console

            //Employee employee = new Employee("Test", "Name"); // in the Employee class the Employee has 3 variables that pass through- fname, lname, and Id. However, you can pass through just the fname and lname and the
            //// Id will be set to the default of 0

            //Console.ReadLine();

            //********** Assignment Page 225 **********//

            Console.WriteLine("How Old are you"); // ask the user their age
            DateTime currentDate = DateTime.Now; // gets the current datetime and stores it in currentDate
            int year = currentDate.Year; // from the currentDate store the year in int year
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine()); // stores the users entry in to userAge as an int
                if (userAge < 1) // if the user's age is less than 1
                {
                    throw new InvalidDataException(); // throw an invaliddataexception

                }
                else //otherwise
                {
                    int yearBorn = year - userAge; //subtract the users age from the current year 
                    Console.WriteLine("Approx. year you were born in is: " + yearBorn);   //write to the console. Year is approx because exact year differs depending on when in the current year the person was born
                    //and this calculation isn't that precise. 
                }
            }
            catch (InvalidDataException) // define the exception that was thrown above if the userAge was less than 1 (which would include 0 and anything negative)
            {
                Console.WriteLine("That is not a valid age"); // write this the console.
            }
            catch (Exception) // otherwise, if the error recieved doesn't fall under the above thrown exception it will hit this one instead
            {
                Console.WriteLine("Sorry, something went wrong."); // write a generic error to the console.
            }

            Console.ReadLine();


        }
    }
}
