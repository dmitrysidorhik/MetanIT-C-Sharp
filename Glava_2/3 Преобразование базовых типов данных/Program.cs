using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Преобразование_базовых_типов_данных
{
    class Program
    {
        static void Main(string[] args)

        {
            byte a = 3;
            int c = a + 5; //расширяющее преобразование (widening) // byte -> int
            Console.WriteLine(c.GetType() + " c= " + c + "\n" + a.GetType() + " a= " + a);
            Console.ReadKey();
            Console.WriteLine();


            byte d = 7;
            byte g = (byte)(d + 60); //сужаюшее преобразование (narrowing)  // int -> byte
            //нужно явно преобразовать 60 в byte 
            Console.WriteLine(d.GetType() + " d= " + d + "\n" + g.GetType() + " g= " + g);
            Console.ReadKey();
            Console.WriteLine();



            int aa = 1;
            int bb = 2;
            // byte c = aa + bb; ---ERROR
            //-----Нам надо применить явное преобразование к типу byte:
            byte cc = (byte)(aa + bb);
            Console.WriteLine(cc.GetType() + " cc= " + cc);
            //aa и bb после операции сложения все равно остается int-типом
            Console.WriteLine(aa.GetType() + " aa= " + aa + "\n" + bb.GetType() + " bb= " + bb);
            Console.ReadKey();
            Console.WriteLine();



            //Потеря данных  
            int s1 = 200;
            int s2 = 56;
            byte s3 = (byte)(s1 + s2); //не попадает в допустимый диапазон для типа byte, и старшие биты будут усекаться
            Console.WriteLine("s3= "+ s3); //выведет 0, если 57 -> выведет 1
            Console.ReadKey();
            Console.WriteLine();



            //ключевое слово cheked
            try
            {
                int d1 = 100;
                int d2 = 200;
                byte d3 = checked((byte)(d1 + d2));
                Console.WriteLine(d3);
            }
            catch (OverflowException ex)
            {
                Console.Write(ex.Message);                
            }
            Console.ReadKey();

        }
    }
}
