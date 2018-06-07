using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_this
{
    class Program
    {
        static void Main(string[] args)
        {//------------------------------------------------------
            User user = new User();
            user.Info();
            user.age = 12;
            user.name = "ONMAN";
            user.Info();
            User user1 = new User("Angel");
            user1.Info();
            User user2 = new User("Oleg");
            user2.Info();
            User user3 = new User("OMAN", 23);
            user3.Info();
            //---------------------------------------------------
            Person person_this = new Person();
            person_this.GetInfo();
            Console.ReadKey();
        }
    }
    class User
    {//---------------------------------------------------------
        public string name;
        public int age;
        public User()
        {
            name = "dev";
            age = 14;
        }
        public User(string n)
        {
            name = n;
            age = 19;
        }
        public User(string n, int a)
        {
            name = n;
            age = a;
        }
        public void Info()
        {
            Console.WriteLine($"{name} - {age}");
        }
        //----------------------------------------------------
        
    }
    class Person
    {
        public string name;        
        public int age;
        public Person() : this("Неизвестно")
        {
        }
        public Person(string name):this(name,45)
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"NAME: {name} , {age} ");
        }

    }
}
