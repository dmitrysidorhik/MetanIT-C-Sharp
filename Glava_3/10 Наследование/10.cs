using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Наследование
{
    class Person
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
          
        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
    class Employee : Person
    {
        public void Display()
        {
            //Console.WriteLine(_firstName); // Error
            Console.WriteLine(FirstName);
        }
    }
    class Program
    {
        static void Main2(string[] args)
        {
            Person p = new Person { FirstName = "Bill", LastName = "Gates" };
            p.Display();
            p = new Employee { FirstName = "Denis", LastName = "Ritchi" };
            p.Display();
            Console.ReadKey();
        }
    }
}
