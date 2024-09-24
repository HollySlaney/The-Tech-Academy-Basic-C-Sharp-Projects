using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //User input weight of package
            Console.WriteLine("Please enter weight of package in pounds.");

            //Convert string to int
            int weight = Convert.ToInt32(Console.ReadLine());

            //If weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            //User input package width
            Console.WriteLine("Please enter package width in inches.");
            int width = Convert.ToInt32(Console.ReadLine());
           
            //User input package height
            Console.WriteLine("Please enter package height in inches.");
            int height = Convert.ToInt32(Console.ReadLine());
            
            //User input package length
            Console.WriteLine("Please enter package length in inches.");
            int length = Convert.ToInt32(Console.ReadLine());

            //Add total dimensions
            int totalDimensions = width + height + length;

            //If dimensions are greater than 50
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            //Else multiply dimensions
            else
            {
                int product = width * height * length;
            
            //Multiply product total by weight and divide by 100
                int calculation = (product * weight) / 100;

            //Result of calculation and converted to dollar amount
                Console.WriteLine($"Your estimated total for shipping this package is: {calculation:C}");
                Console.WriteLine("Thank you!");
            }


            Console.ReadLine();
        }
    }
}
