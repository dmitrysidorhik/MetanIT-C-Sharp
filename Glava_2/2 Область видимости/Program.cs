using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Область_видимости
{
    class Program
    {
        ////при работе с переменными надо учитывать, что локальные переменные,
        ////определенные в методе или в блоке кода, скрывают переменные уровня класса, если их имена совпадают
        int a = 4;
        static void Main(string[] args)
        {
            int a = 6;
            Console.WriteLine(a); //Выведет: 6
            Console.ReadKey();
        }

    }
}
