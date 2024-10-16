using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create an abstract class with two string properties
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Give it the method SayName()
        public abstract void SayName();
    }
}
