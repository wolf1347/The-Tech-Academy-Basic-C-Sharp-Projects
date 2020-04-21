using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    public class Employee: Person, IQuittable // inherits from both Person (the parent class) and IQuittable (the interface)
    {
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
    }
}
