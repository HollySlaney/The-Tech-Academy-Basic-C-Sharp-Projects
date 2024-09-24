using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            //Title
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //Person 1
            Console.WriteLine("Person 1");
            
            //Hourly Rate
            Console.WriteLine("Hourly Rate:");
            string hourlyRate1 = Console.ReadLine();
            
            //Amount of hours
            Console.WriteLine("Hours worked per week:");
            string hours1 = Console.ReadLine();

            //Equation for annual salary
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            
            //Person 2
            Console.WriteLine("Person 2");

            //Hourly Rate
            Console.WriteLine("Hourly Rate:");
            string hourlyRate2 = Console.ReadLine();
            
            //Amount of hours
            Console.WriteLine("Hours worked per week:");
            string hours2 = Console.ReadLine();

            //Equation for annual salary
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;

            //Annual for Person 1
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            //Annual for person 2
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            //Boolean equation for annual salary
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
