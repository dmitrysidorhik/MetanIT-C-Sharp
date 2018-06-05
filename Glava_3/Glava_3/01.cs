using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava_3
{
    class Program
    {
        class Person
        {
            // Здесь используется конструктор по умолчанию
            public string name;
            public int age;
            public void GetInfoPerson()
            {
                Console.WriteLine($"Имя: {name} Возраст: {age}");
            }
        }

        class Persons
        {
            public string name;
            public int age;
            public Persons() //Свой конструктор
            {
                name = "Неизвестно";
                age = 18;
            }
            public Persons(string n)
            {
                name = n;
                age = 18;
            }
            public Persons(string n, int a)
            {
                name = n;
                age = a;
            }
            public void GetInfoPersons()
            {
                Console.WriteLine($"Имя: {name} Возраст: {age}");
            }

        }

        class Pesrons_this
        {
            public string name;
            public int age;
            public Pesrons_this() : this("Неизвестно")  //Первый класс обр. ко 2-му, а 2-ой к 3-му               
            {                 
            }
            public Pesrons_this(string name) : this(name, 18)
            {
            }
            public Pesrons_this(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void GetInfoPersons_this()
            {
                Console.WriteLine($"Имя: {name} Возраст: {age}");
            }
        }

        static void Main(string[] args)
        {
            Person tom=new Person(); //Для создания объека Person используем new Person
            tom.GetInfoPerson();
            tom.name = "Tom";
            tom.age = 23;
            tom.GetInfoPerson();
            Console.WriteLine("---------------------Конструкторы-------");

            Persons Tom = new Persons();
            Tom.GetInfoPersons();
            Persons James = new Persons("James");
            James.GetInfoPersons();
            Persons Oliver = new Persons("Oliver", 32);
            Oliver.GetInfoPersons();
            Console.WriteLine("---------------------Ключевое слово this------");

            Pesrons_this Jack = new Pesrons_this { name = "Jack", age = 21 }; //Инициализатор объекта
            Jack.GetInfoPersons_this();
            Console.ReadKey();
        }
    }
}
