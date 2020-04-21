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

            //********** Assignment Page 179**********//


            Employee employee = new Employee(); // calls on the Employee class which will be called employee
            employee.FirstName = "Sample"; // sets First Name to Sample
            employee.LastName = "Student"; // sets Last Name to Student
            employee.Quit(employee); // calls on the Quit method in Employee which was inherited via the IQuittable interface. Typically Employee would only be able to inherit one class, currently set to Person, but
            //using the interface allows it to inherit from IQuittable as well and take the Quit function.
            Console.ReadLine();

        }
    }
}
