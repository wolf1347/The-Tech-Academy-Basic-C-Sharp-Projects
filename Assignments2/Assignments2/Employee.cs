using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    public class Employee: Person, IQuittable // inherits from both Person (the parent class) and IQuittable (the interface)
    {

        public int Id { get; set; }
        public List<Employee> Employees{ get; set; }


        public override void SayName() //creates the SayName function which is required of the Person parent class
        {
            Console.WriteLine("Employee information \n"); // adds to the SayName function it inherits from the parent class with an Employee specific addition
            base.SayName(); // the base code for the SayName function that it inherits. Functionally it is the same as the below code in the parent class

            //public virtual void SayName()
        //{
            //Console.WriteLine("Name: " + FirstName + " " + LastName);
        //}
    }

        public void Quit(Employee employee) // adds the Quit function inherited from the IQuittable interface
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName + " has quit.");
        }

        public static Boolean operator ==(Employee employee1, Employee employee2) // overload of the == operator to return a boolean value
        {
            if (employee1.Id == employee2.Id) // if the IDs are equal
            {
                Console.WriteLine("The employee IDs match so this is the same employee"); // write this to the console and return true
                return true;
            }
            else {
                
                Console.WriteLine("The employee IDs do not match so this is not the same employee"); // otherwise if they are not equal write this to the console and return false
                return false;
            }

        }

        public static Boolean operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id) // overload of the != operator to return a boolean value
            {
                Console.WriteLine("he employee IDs do not match so this is not the same employee"); // if the IDs are not equal
                return true; // write this to the console and return true
            }
            else 
            {
                Console.WriteLine("The employee IDs match so this is the same employee"); // otherwise if they are equal write this to the console and return false
                return false;
            }

            
        }

    }
}
