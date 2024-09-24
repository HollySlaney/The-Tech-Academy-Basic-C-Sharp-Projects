using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Concatenate 3 strings
            //string firstName = "Holly ";
            //string middleName = "Anne ";
            //string lastName = "Slaney";
            //string name = firstName + middleName + lastName;
            //Console.WriteLine(name);

            ////Convert a string to uppercase
            //string name = "Holly Slaney";
            //Console.WriteLine(name.ToUpper());

            //StringBuilder to build a paragraph one sentence at a time
            StringBuilder newString = new StringBuilder();

            newString.Append("Hello, there! ");
            newString.Append("My name is Holly. ");
            newString.Append("I live in Western Canada.");
            Console.WriteLine(newString);
            
            Console.ReadLine();
        }
    }
}
