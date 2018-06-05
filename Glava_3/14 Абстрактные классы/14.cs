using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Абстрактные_классы
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person(string name, string surname)
        {
            FirstName = name;
            LastName = surname;            
        }
        public abstract void Display();
                  
    }
    class Client : Person
    {
        public int Sum { get; set; } // сумма на счета
        public Client(string name, string surname, int sum) : base(name, surname)
        {
            Sum = sum;
        }
        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} имеет счет на сумму {Sum}");
        }
    }
    class WorkMan : Person
    {
        public string Position { get; set; } // должность
        public WorkMan(string name, string surname, string position) : base(name, surname)
        {
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} должность {Position} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Главное отличие состоит в том, что мы не можем использовать конструктор 
            //абстрактного класса для создания его объекта. Абстрактный класс Human
            // Human h = new Human(); 
            Client client = new Client("Tom", "Smith", 500);
            WorkMan workMan = new WorkMan("Bob", "Tompson", "Менеджер");
            client.Display();
            workMan.Display();
            Console.ReadKey();
        }
    }
}
