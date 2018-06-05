using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Работа_с_консолью_и_класс__Console_
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.BackgroundColor =ConsoleColor.DarkBlue; //цвет фона
            Console.Clear();//очистка консоли                        
            Console.ForegroundColor = ConsoleColor.Yellow; //цвет текста
            for (int i = 0; i < 10; i++)
            {
                Console.Beep(); //звуковой сигнал
                Console.WriteLine(i);               
            }                         
            Console.BackgroundColor = ConsoleColor.Cyan; //цвет фона 
            Console.Clear();//очистка консоли         
            Console.ForegroundColor = ConsoleColor.DarkGreen; // установка зеленого цвета шрифта
            try
            {
                do
                {
                    Console.WriteLine("Введите первое число");
                    int num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    int num2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Сумма чисел {0} и {1} равна {2}", num1, num2, num1 + num2);

                    Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую другую клавишу");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape); //Определенная клавиша
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
