using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Преобразование_типов
{
    class Account<T>
    {
        public T Id { get; set; }
        public int Sum { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account <int> account1 = new Account<int> { Sum = 5000 };
            Account <string>account2 = new Account<string> { Sum = 4000 };
            account1.Id = 2;
            account2.Id = "3423";
            int id1 = account1.Id;
            string id2 = account2.Id;
            Console.WriteLine(id1);
            Console.WriteLine(id2);
            Console.ReadKey();


        }
    }
}
