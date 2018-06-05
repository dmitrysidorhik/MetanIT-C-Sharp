using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Переопределение_виртуальных_методов
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastNmae { get; set; }
        public Person(string firstName, string lasName)
        {
            FirstName = firstName;
            LastNmae = lasName;
        }
        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastNmae}");
        }
    }
    class Employee:Person
    {
        public string Company { get; set; }
        public Employee(string firstName, string lastName, string company) : base(firstName, lastName)
        {
            Company = company;
        }

        //Переопределение виртуального метода (модификатопр override)
       /* public override void Display()
        {
            //base.Display();
            //Console.WriteLine($"работает в {Company}");
            Console.WriteLine($"{FirstName} {LastNmae} работает в {Company}");
        }*/

        /////Запрет переопределения методов (модификатор sealed)
        public override sealed void Display()
        {
            Console.WriteLine($"{FirstName} {LastNmae} работает в {Company}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill", "Gates");
            p1.Display();
            Employee p2 = new Employee("Tom", "Smith", "Micosoft");
            p2.Display();
            Console.ReadKey();
        }
    }
}
