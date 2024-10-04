﻿using System;
using System.Collections.Generic;
class Program
{ 
    static void Main(string[] args)
    {
        //Create a list of integers
        List<int> intList = new List<int>() { 70, 33, 455, 42, 3, 5004, 678, 1238, 2, 53 };

        //Ask the user for input and loop through the list dividing each number by the input
        bool numValid = false;
        while (!numValid)
        {
            //Using a try/catch block give error message
            try
            {
                Console.WriteLine("\nEnter a number to divide the list by: ");
                float numDivide = float.Parse(Console.ReadLine());

                //If statement to check if the user entered 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                
                //Dividing each number in the list by the input
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }
            //Catch block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        //Message to let the user know the program has exited the try/catch block
        Console.WriteLine("The program has exited the try/catch block.");

        Console.ReadLine();
    }
    
}
