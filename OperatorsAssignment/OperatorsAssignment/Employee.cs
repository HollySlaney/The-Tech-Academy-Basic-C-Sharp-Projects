using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Overloading the == operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //Compare Id properties
            return employee1.Id == employee2.Id;

        }
        //Overloading the != operator as the overloading pair to == operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
