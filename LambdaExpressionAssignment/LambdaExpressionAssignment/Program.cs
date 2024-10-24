using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of at least 10 employees
            //Two employees should have the first name "Joe"
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {Id = 1, firstName = "Joe", lastName = "Pate"},
                new Employee() {Id = 2, firstName = "John", lastName = "Dote"},
                new Employee() {Id = 3, firstName = "Jane", lastName = "Thomas"},
                new Employee() {Id = 4, firstName = "Joe", lastName = "Lane"},
                new Employee() {Id = 5, firstName = "Colleen", lastName = "Bartrim"},
                new Employee() {Id = 6, firstName = "Bill", lastName = "Downing"},
                new Employee() {Id = 7, firstName = "Carol", lastName = "Akerley"},
                new Employee() {Id = 8, firstName = "Joe", lastName = "Audette"},
                new Employee() {Id = 9, firstName = "Matthew", lastName = "Richardson"},
                new Employee() {Id = 10, firstName = "Lindsey", lastName = "Stevens"}
            };
            //Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Now with a lambda expression
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //Make a list of all employees with an Id number greater than 5, using a lambda expression
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
