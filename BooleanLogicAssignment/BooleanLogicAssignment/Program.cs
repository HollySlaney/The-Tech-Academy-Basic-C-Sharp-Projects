using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Car Insurance Application");

            //Age
            Console.WriteLine("What is your age?");

            //Convert age from string to int then result
            int age = Convert.ToInt32(Console.ReadLine());

            //DUI yes or no
            Console.WriteLine("Have you ever had a DUI? Please answer yes or no.");

            //Result
            string answer = Console.ReadLine().ToLower();

            //If answer yes then true to DUI
            bool dui = answer == "yes";

            //Speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");

            //Convert age from string to int then result
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Do you qualify
            Console.WriteLine("Do you qualify for insurance?");

            //Qualifications for true
            bool qualified = (age > 15) && !dui && (tickets <= 3);

            //Result
            Console.WriteLine(qualified);

       
            Console.ReadLine();
        }
    }
}
