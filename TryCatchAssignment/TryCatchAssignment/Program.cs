using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for their age
            Console.WriteLine("How old are you?");
            //Try/catch block
            try
            {
                //Convert age to an integer
                int age = Convert.ToInt32(Console.ReadLine());
                //Current year
                int currentYear = DateTime.Now.Year;
                //Birth year
                int birthYear = currentYear - age;
                if (age <= 0)
                {
                    //Error message if user inputs zero or negative number
                    Console.WriteLine("Input cannot be zero or a negative number.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    //Display the year the user was born
                    Console.WriteLine("You were born in the year: " + birthYear);
                }
            }
            //General message if exception was caused by anything else
            catch (FormatException)
            {
                Console.WriteLine("That's not a valid age! Please enter a number.");
            }
            
            Console.ReadLine();
        }
    }
}
