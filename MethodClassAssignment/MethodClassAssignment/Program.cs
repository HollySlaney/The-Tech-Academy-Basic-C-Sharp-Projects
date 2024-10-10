using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathOperation class
            MathOperation math1 = new MathOperation();
            //Call the method passing in two numbers
            math1.mathOperation(10, 50);
            //Call the method parameters by name
            math1.mathOperation(a: 10, b: 50);
            Console.ReadLine();
        }
    }
}
