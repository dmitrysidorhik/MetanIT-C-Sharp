using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Свойства_и_инкапсуляция
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();        
            p.Name = "Tom"; // Устанавливаем свойство - срабатывает блок Set
            //значение Tom  и есть передаваемое в свойство value
            string personName = p.Name;//получаем значение свойства и присваиваем его переменной - срабатывает блок Get

            Person s = new Person();
            s.Age = 17;
            int personAge = s.Age;
            Console.WriteLine(personAge);

            //Person w = new Person("John", 23);
            Console.ReadKey();
        }
    }
    class Person
    {
        private string name; // закрытое поле
        public string Name // Свойство Name, возвращаемый тип - string 
        {
            get //В этом блоке мы возвращаем значение поля
            {
                return name;
            }
            set //В этом блоке мы устанавливаем значение поля
            {
                name = value; //Параметр value представляет передаваемое значение
            }
        }

        private int age;  // закрытое поле
        public int Age // Свойство Age, возвращаемый тип - int 
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть меньше 17");
                }
                else
                {
                    age = value;
                }
            }
        }

        /////////////////// Автоматическое свойство
        public string Names { get; set; } = "For";
        public int Ages { get; set; } = 24;
        public Person(string names, int ages)
        {
            Names = names;
            Ages = ages;
        }
    }
}
