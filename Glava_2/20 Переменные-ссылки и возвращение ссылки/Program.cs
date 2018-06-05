using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Переменные_ссылки_и_возвращение_ссылки
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine(x);
            xRef = 23;
            Console.WriteLine(x);
            int z = 56;
            ref int yRef = ref z;
            Console.WriteLine(z);
            Console.WriteLine("Значение по ссылке:" + z);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            ref int numberRef = ref Find(5, numbers);
            numberRef = 70;
            Console.ReadLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
        static ref int Find(int number, int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException("Число не найдено");
        }
    }
}
