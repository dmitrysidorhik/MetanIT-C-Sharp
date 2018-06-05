using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2
{
    class Program
    {
        static void Add(int s,params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        static void Main()
        {
            Add(1, 3, 4);
            int[] array = new int[] { 1, 2, 4 };
            Add(2,array);
            Console.ReadKey();
        }
    }
}
