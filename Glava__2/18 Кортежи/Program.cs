using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _18_Кортежи
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (5, 10,"text",3); //задан неявно
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);            
            tuple.Item1 += 12;
            Console.WriteLine(tuple.Item1);
            Console.ReadKey();
            /*
            (int, double) tuple_2 = (7, 14.14); //задан явно
            //(int, double) tuple_2 = (7.47, 14); //задан явно - НЕЛЬЗЯ
            Console.WriteLine(tuple_2.Item1);
            Console.WriteLine(tuple_2.Item2);
            (int, string, double) kortege = (45, "string", 47.89);
            Console.WriteLine(kortege.Item1 + kortege.Item3+kortege.Item2);
            //названия полям корежа
            ///var kortege_2 = (count: 5, sum: 23);
            ///Console.WriteLine(kortege_2.count);
            Console.ReadKey();*/
        }
    }
}
