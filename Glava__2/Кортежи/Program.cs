using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кортежи
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1);
            tuple.Item1+= 2;
            Console.WriteLine(tuple.Item1);
            var tuple_2 = (count: 6, sum: 8); //Задаём имена полей кортежа
            Console.WriteLine(tuple_2.count); //обращаемся по имени, выведет 6
            Console.WriteLine(tuple_2.sum); // 8
            var (name, age) = ("Tom", 23); // (не исп. перем. для определения кортежа) использование отдельных переменных для его полей
            Console.WriteLine(name);
            Console.WriteLine(age);

            Console.WriteLine("Возвращение из функции двух и более значений, в то время как функция можно возвращать только одно значение.И кортежи представляют оптимальный способ для решения этой задачи");
            
            /////////// - GetValues() 
            var tuple_3 = GetValues();
            Console.WriteLine(tuple_3.Item1);
            Console.WriteLine(tuple_3.Item2);
            /////////// - GetNamedValues
            var tuple_4 = GetNamedValues(new int[] {2, 4, 6, 8,10 });
            Console.WriteLine("Количество= "+tuple_4.znah);
            Console.WriteLine("Сумма= "+ tuple_4.summa);
            Console.WriteLine("Среднее= " + tuple_4.srednee);
            /////////// - GetTuple
            var (name_,age_)= GetTuple(("Jerry", 23), 12);
            Console.WriteLine(name_);
            Console.WriteLine(age_);


            Console.ReadKey();
        }
        private static (int, int) GetValues() 
        {
            var result = (1, 3);
            return result; //Функция возвращает 2 значения
        }
        private static (int znah, int summa, int srednee) GetNamedValues(int[] numbers)
        {
            var result_2 = (znah: 0, summa: 0,srednee:0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result_2.summa += numbers[i];
                result_2.znah++;
            }
            result_2.srednee = result_2.summa / result_2.znah;
            return result_2;
        }
        private static (string name_, int age_) GetTuple((string d, int s) tuple, int x)
        {
            var result_3 = (name_: tuple.d, age_: tuple.s + x);
            return result_3;
        }



    }
}
