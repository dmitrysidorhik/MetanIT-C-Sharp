using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Перегрузка_методов
{
    class Program
    {
        static void Main(string[] args)
        {            
            Calculator calc = new Calculator();
            calc.Add(1, 2); // 3
            calc.Add(1, 2, 3); // 6
            calc.Add(1, 2, 3, 4); // 10
            calc.Add(1.4, 2.5); // 3.9            
            Console.ReadKey();
        }
    }
    class Calculator
    {   //Определены 4 перегрузки метода Add
        public void Add(int a, int b) //метод Add
        {
            int result = a + b;
            Console.WriteLine($"Result is {result}");
        }
        public void Add(int a, int b, int c)//метод Add
        {
            int result = a + b + c;
            Console.WriteLine($"Result is {result}");
        }
        public int Add(int a, int b, int c, int d)//метод Add
        {
            int result = a + b + d;
            Console.WriteLine($"Result is {result}");
            return result;
        }
        public void Add(double a, double b)//метод Add
        {
            double result = a + b;
            Console.WriteLine($"Result is {result}");
        }
    }
}
