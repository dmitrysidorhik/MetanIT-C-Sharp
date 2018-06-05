using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Наследование
{
    class Person2
    {
        public string FirstName { get; set; }
        public string LastNmae { get; set; }
        public Person2(string firstName, string lastName)
        {
            FirstName = firstName;
            LastNmae = lastName;
        }
        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastNmae}");
        }
    }
    class Employee2 : Person2
    {
        public string Company { get; set; }
        public Employee2(string firstName, string lastName, string comp) : base(firstName, lastName)
        {
            Company = comp;
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Person2 p2 = new Person2("Bill", "Gates");
            p2.Display();
            Employee2 emp = new Employee2("Tom", "Simpson", "Microsoft");
            emp.Display();
            Console.ReadKey();
        }
    }
}
