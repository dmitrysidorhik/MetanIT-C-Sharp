using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Класс_System.Object_и_его_методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Tom" };
            Console.WriteLine(person.ToString());
            Clock clock = new Clock { Hour = 12, Minute = 34, Seconds = 11 };
            Console.WriteLine(clock.ToString());
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return base.ToString();
            return Name;
        }
    }
    class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hour} {Minute} {Seconds}";
        }
    }
}
