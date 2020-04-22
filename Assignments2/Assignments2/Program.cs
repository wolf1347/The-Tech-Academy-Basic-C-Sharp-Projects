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


            //********** Assignment Page 184**********//

            var employee1 = new Employee {FirstName="Amber", LastName="Wolf", Id=01 }; // instantiate the Employee class in to employee1
            var employee2 = new Employee {FirstName = "Deku", LastName = "Wolf", Id = 02 }; // instantiate the Employee class in to employee1

            List<Employee> employeeList = new List<Employee>() // initialize a list and add the new instances of Employee in to it
            {
               employee1,
               employee2
            };


            if (employee1 == employee2) // compare statement using the overload ==
            {

            }
            

            Console.ReadLine();
        }
    }
}
