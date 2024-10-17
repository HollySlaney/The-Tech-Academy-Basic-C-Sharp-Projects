using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = " Student" };
            //Call SayName method on object
            sam.SayName();
            //Polymorphism to create object and call Quit() method
            IQuittable quit = new Employee();
            quit.Quit();
            Console.ReadLine();
        }
    }
}
