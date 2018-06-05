using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Программа_сортировки_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            int[] array_2 = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}-е число массива: " , i + 1);                
                array[i] = Int32.Parse(Console.ReadLine());                
            }
            //sortirovka
            int temp;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
