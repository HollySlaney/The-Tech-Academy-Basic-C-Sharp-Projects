using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Make Employee class inherit from Person class
    public class Employee : Person
    {
        public int Id { get; set; }
        //Implement teh SayName() method inside of Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
