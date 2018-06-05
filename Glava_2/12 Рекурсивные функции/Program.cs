using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Рекурсивные_функции
{
    class Program
    {
        /*          
         * Рекурсивная функция представляет такую конструкцию, при которой функция вызывает саму себя.
         * */
        static void Main(string[] args)
        {
            Console.Write("Введите число факториала: ");
            int q=Int32.Parse(Console.ReadLine());            
            Console.WriteLine("Factorial {0}: " +Factorial(q),q);
            Console.ReadKey();

            Console.Write("Введите число Фиббоначчи: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write ("Фиббоначчи {0}: " + Fibonachi(a), a);
            Console.ReadKey();

        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(x);
                return x*Factorial(x - 1);                
            }
        }
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
