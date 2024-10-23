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
            //Instantiate Employee object with string data type as its generic parameter
            Employee<string> stringEmployee = new Employee<string>
            {
                Id = "FVH566",
                firstName = "Holly",
                lastName = "Slaney",
                Things = new List<string> { "Name Tag", "Vest", "Tie" }
            };

            Employee<int> intEmployee = new Employee<int>
            {
                Id = 325,
                firstName = "Stephanie",
                lastName = "Parker",
                Things = new List<int> { 654, 475, 978 }
            };

            //Loop through and print all the things for stringEmployee
            Console.WriteLine("Things for Employee " + stringEmployee.firstName + " " + stringEmployee.lastName + " (Id: " + stringEmployee.Id + "):");
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine();

            //Loop through and print all the things for intEmployee
            Console.WriteLine("Things for Employee " + intEmployee.firstName + " " + intEmployee.lastName + " (Id: " + intEmployee.Id + "):");
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
