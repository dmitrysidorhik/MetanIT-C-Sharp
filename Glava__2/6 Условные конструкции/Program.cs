using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Условные_конструкции
{
    class Program
    {
        static void Main(string[] args)
        {
            //В конце каждого блока сase должен ставиться один из операторов перехода: 
            //break, goto case, return или throw.Как правило, используется оператор break. 
            //При его применении другие блоки case выполняться не будут.

            //Однако если мы хотим, чтобы, наоборот, после выполнения текущего блока case 
            //выполнялся другой блок case, то мы можем использовать вместо break оператор goto case:

            Console.WriteLine("Break");
            string num = Console.ReadLine();
            int _num;
            Int32.TryParse(num, out _num); //преобр. string в int
            switch (_num)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
            }
            Console.ReadKey();

            Console.WriteLine("Goto case");
            string num1 = Console.ReadLine();
            int _num1;
            Int32.TryParse(num1, out _num1); //преобр. string в int
            switch (_num1)
            {
                case 1:
                    Console.WriteLine("case 1");
                    
                    goto case 3; //еще выполнит и case 3 
                case 2:
                    Console.WriteLine("case 2");
                    return; //Применение оператора return позволит выйти не только из блока case, 
                    //но и из вызывающего метода. метод Main завершит работу.
                case 3:
                    Console.WriteLine("case 3");
                    break;
                default:
                    Console.WriteLine("default");
                    break;

            }
            //Оператор throw применяется для выброса ошибок 
            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
