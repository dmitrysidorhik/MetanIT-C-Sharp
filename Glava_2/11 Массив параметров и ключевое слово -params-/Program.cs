using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Массив_параметров_и_ключевое_слово__params_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Во всех предыдущих примерах мы использовали постоянное 
             * число параметров. Но, используя ключевое слово params, 
             * мы можем передавать неопределенное количество параметров: */
            Addition(1, 2, 3, 4, 5); //передаём отдельные значения
            int[] array = new int[] { 1, 2, 3, 4 };
            Addition(array); //передаём массив значений
            Addition(); //пничего не передаём
            Console.ReadLine();
            //Однако данный способ имеет ограничения: 
            //после параметра с модификатором params мы не можем указывать другие параметры:
            // static void Addition(params int[] integers, int x, string mes) --- НЕЛЬЗЯ ТАК
        }
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine("------------");
            Console.WriteLine(result);
            Console.WriteLine(integers.Length);
            Console.WriteLine("------------");
        }
    }
}