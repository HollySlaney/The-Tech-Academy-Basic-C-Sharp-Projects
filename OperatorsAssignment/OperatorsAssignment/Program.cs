using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Employees and assign values to their properties
            Employee employee1 = new Employee
            {
                Id = 1,
                firstName = "Holly",
                lastName = "Slaney"
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                firstName = "Stephanie",
                lastName = "Parker"
            };

            //Compare the two employees using == overloaded operator and display results
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employees are equal.");
            }
            //Compare employees using the != overloaded operator and display results
            if (employee1 != employee2)
            {
                Console.WriteLine("The two employees are not equal.");
            }
            Console.ReadLine();
        }
    }
}
