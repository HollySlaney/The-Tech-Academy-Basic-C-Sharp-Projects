using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int countdown = 7;

            //Loop until count goes down to 0
            while (countdown > 0)
            {
                //Print current value
                Console.WriteLine(countdown);
                //Decrease by 1 after each loop
                countdown--;
            }

            //Do while loop
            int i = 1;
            do
            {
                Console.WriteLine(i);
                //Add 1 after each loop
                i++;
                //Break the loop when i is greater than 8
                if (i > 8)
                {
                    break;
                }
            }
            //Continue to loop while condition is true
            while (true);

            Console.ReadLine();
        }
    }
}
