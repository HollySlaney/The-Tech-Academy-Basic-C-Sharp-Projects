using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public struct Number
    {
        public decimal Amount { get; set; }
        public Number(decimal amount)
        {
            Amount = amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of data type Number and assign an amount to it
            Number myNumber = new Number(123.45m);
            //Display the amount
            Console.WriteLine("The amount is: " + myNumber.Amount);
            Console.ReadLine();
        }
    }
}
