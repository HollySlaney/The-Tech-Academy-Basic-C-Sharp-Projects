using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main()
        {
            //Fruit array
            string[] fruitArray = { "Apple", "Orange", "Banana", "Kiwi", "Strawberry", "Mango", "Pineapple", "Raspberry", "Grapefruit", "Peach" };
            //User index input
            Console.WriteLine("Select an index between 0 and 9:");
            //Display user input
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite fruit is " + fruitArray[stringSelect]);
                    validString = true;
                }
                //Message to display if user picks an index that does not exist
                catch
                {
                    Console.WriteLine("Sorry, that number is invalid. Please choose a number between 0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());

                }
            }

            //List of strings
            List<string> occupationList = new List<string>()
    {   "Data Analyst",
        "UX Designer",
        "Artist",
        "Teacher",
        "Lawyer",
        "Cowboy",
        "Athlete",
        "Podcast Host",
        "Software Developer",
        "QA Tester",
    };

            //User index input
            Console.WriteLine("\nSelect another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                //Message to display if user picks an index that does not exist
                catch
                {
                    Console.WriteLine("Sorry, that number is invalid. Please choose a number between 0 and 9.");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Array of integers
            int[] intArray = { 9, 13, 95, 28, 2, 80, 7, 34, 51, 5 };
            //User index input
            Console.WriteLine("\nSelect a third number between 0 and 9:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                //Message to display if user picks an index that does not exist
                catch
                {
                    Console.WriteLine("Sorry, that number is invalid. Please choose a number between 0 and 9.");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }

                Console.ReadLine();
            }
        }
    }
}

