using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
     public class MathOperation
    {
        //Void method with two integers as parameters
        public void mathOperation(int a, int b)
        {
            //Math operation on first integer
            int result = a * 5;
            //Display the second integer
            Console.WriteLine("The second integer is: " + b);
        }
    }
}
