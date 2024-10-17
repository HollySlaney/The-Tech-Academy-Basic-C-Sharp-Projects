using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Make Employee class inherit from Person class
    //Inherit IQuittable interface
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //Implement Quit() method
        public void Quit()
        {
            Console.WriteLine("Employee has quit.");
        }
    }
}
