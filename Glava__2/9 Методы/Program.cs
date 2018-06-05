using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _9_Методы
{
    class Program
    {        
        static void Main(string[] args) //метод, который ничего не возвращает, называется - продцедура (не возвращает значение)
        {            
            string message = Hello();
            Console.WriteLine(message);
            Prodcedure1();
            Prodcedure2(12);
            SUM();
            SUM2(4, 6);
            Console.ReadKey();
        }
        static string Hello() ///Метод или функция (возвращает значение)
        {             
            return "yes";
        }
        static void Prodcedure1() //продцедура
        {
            Console.WriteLine("Prodcedure1");
        }
        static void Prodcedure2(int a) //продцедура
        {
            Console.WriteLine("Prodcedure2 " + a);
        }
        static void SUM() 
        {
            int x = 2;
            int y = 3;
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
        }
        static void SUM2(int x, int y)
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
        }


    }
}
