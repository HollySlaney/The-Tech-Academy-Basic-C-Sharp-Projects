using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize an employee object
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //The superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
