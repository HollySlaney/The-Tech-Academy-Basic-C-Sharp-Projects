using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //File path where the number will be logged
            string filePath = @"C:\Users\Mom\Logs\log.txt";
            //Ask the user for a number
            Console.WriteLine("Please input a number between 1 and 100.");
            int answer = int.Parse(Console.ReadLine());
            //Logs number to file
            File.WriteAllText(filePath, answer.ToString());
            //Print text file back to user
            string loggedNumber = File.ReadAllText(filePath);
            Console.WriteLine("The logged number is: " + loggedNumber);
            
            Console.ReadLine();

        }
    }
}
