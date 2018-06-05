using System;

namespace _7_Циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("break в цикле");
            int[] array = new int[5] { 1, 3, 6, 11, 9 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 10)
                {
                    Console.WriteLine("Произошёл выход из цикла (не завершился)");
                    break;
                }
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("continue в цикле");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 10)
                {
                    Console.WriteLine("Пропускаем текущий и проверяем следующий эемент");
                    continue;
                }
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
