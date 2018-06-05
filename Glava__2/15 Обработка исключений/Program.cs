using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Обработка_исключений
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            try
            {
                a[6] = 4; // тут возникнет исключение, так как у нас в массиве только 4 элемента
                Console.WriteLine("Завершение блока try");
            }
           // catch (IndexOutOfRangeException ex)
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            
            //Чтобы сообщить о выполнении исключительных ситуаций в программе, можно использовать оператор throw. 
            //То есть с помощью этого оператора мы сами можем создать исключение и вызвать его в процессе выполнения.
            try
            {
                Console.WriteLine("Введите строку: ");
                string message = Console.ReadLine();
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов"); //СОЗДАём СВОё исключение
                }
                Console.WriteLine("Строка не переполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
             
            //Обработка исключений и условные конструкции
            Console.WriteLine("Введите число");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            

            //Фильтры исключений
            //В C# 6.0 (Visual Studio 2015) была добавлена такая функциональность, как фильтры исключений. 
            //Они позволяют обрабатывать исключения в зависимости от определенных условий:

            int xx = 1;
            int y = 0;

            try
            {
                int result = xx / y;
            }
            catch (Exception exx) when (y == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.Message);
                Console.WriteLine("2-blok");
            }
            Console.Read();
        }
    }
}
