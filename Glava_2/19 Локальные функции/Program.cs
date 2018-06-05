using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Локальные_функции
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetResult(new int[] { -4,-5,-3, -2, -1, 0, 1, 2, 3 ,4,5,6,7});
            Console.WriteLine(result);
            Console.Read();
        }
        static int GetResult(int[] numbers)
        {
            int limit = 5;
            
            bool IsMoreThan(int number) //локальная функция, которая может быть вызвана только внутри этого метода
            {
                return number > limit;
            }
            int result = 0;
            for (int i=0; i < numbers.Length;i++)
            {
                if (IsMoreThan(numbers[i]))
                {
                    result+= numbers[i];
                }
            }
            return result;
        }
    }
}
