using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int z;
            Sum(x, 15, out z);
            Console.WriteLine(z);
            Console.WriteLine(Add(2,4));
            Console.WriteLine(Mdd(y: 2,z:3,k:4,m:-1)); //Можем изменить порядок
            Console.ReadKey();
        }
        static void Sum(int x, int y, out int a )
        {
            a = x + y;
        }
        //-----------Необязательные параметры--------------
        //(Если Add передаёт только 2 значения, то необязательные параметры будут использоваться
        //Если ADD передает все 4 значения, то необязательные параметры использоваться НЕ будут
        static int Add(int  y, int z = 5, int k=6, int m=8)
        {
            return y+z+k+m;
        }
        //-----------Именнованные параметры--------------
        static int Mdd(int y, int z = 5, int k = 6, int m = 8)
        {
            return y + z + k + m;
        }

    }
}
