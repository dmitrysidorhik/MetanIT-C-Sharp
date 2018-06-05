using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Типы_значений_и_ссылочные_типы
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(5);            
            Console.ReadKey();
            State state1 = new State(); // State - структура, ее данные размещены в стеке
            Country country1 = new Country(); // Country - класс, в стек помещается ссылка на адрес в хипе
                                              // а в хипе располагаются все данные объекта country1
        }
        static void Calculate(int t)
        {
            int x = 6;
            int y = 7;
            int z = y + t;
            Console.WriteLine(z);
        }
        struct State
        {
            public int xx;
            public int yy;
            public Country country;
        }
        class Country
        {
            public int xx;
            public int yy;
        }
    }
}
