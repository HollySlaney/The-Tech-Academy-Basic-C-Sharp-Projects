using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee<T>
    {
        public T Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        //List of items of generic type T
        public List<T> Things { get; set; }

        //Overloading the == operator
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            //Compare Id properties
            return EqualityComparer<T>.Default.Equals(employee1.Id, employee2.Id);

        }
        //Overloading the != operator as the overloading pair to == operator
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
