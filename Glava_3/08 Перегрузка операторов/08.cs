using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Перегрузка_операторов
{
    class Counter
    {
        public int Value { get; set; }
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter
            { Value = c1.Value + c2.Value };
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            if (c1.Value > c2.Value)
                return true;
            else
                return false;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            if (c1.Value < c2.Value)
                return true;
            else
                return false;
        }
        public static int operator +(Counter c1, int val)
        {
            return c1.Value + val;
        }      

        /*Следует учитывать, что при перегрузке не должны изменяться те объекты, 
         * которые передаются в оператор через параметры.
        Например, мы можем определить для класса Counter оператор инкремента: */
       // public static Counter operator --(Counter c1)
       // {
       //     c1.Value += 10;
       //    return c1;
       // }
        /*
         Поскольку оператор унарный, он принимает только один параметр - объект того класса, 
         в котором данный оператор определен. Но это неправильное определение инкремента,
         так как оператор не должен менять значения своих параметров.
         И более корректная перегрузка оператора инкремента будет выглядеть так:
         * */
        public static Counter operator ++(Counter c1)
        {
            return new Counter { Value = c1.Value + 10 };
            //То есть возвращается новый объект, который содержит в свойстве Value инкрементированное значение
        }
        public static bool operator true(Counter c1)
        {
            return c1.Value != 0;
        }
        public static bool operator false(Counter c1)
        {
            return c1.Value == 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 34 };

            bool result = c1 > c2;
            Console.WriteLine(result);

            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Value);

            int d = c1 + 27;
            Console.WriteLine(d);

            Counter counter_p1 = new Counter() { Value = 10 };
            Console.WriteLine("Префиксный инкремент");
            Console.WriteLine($"{counter_p1.Value}");
            Console.WriteLine($"{(++counter_p1).Value}"); 
            Console.WriteLine($"{counter_p1.Value}");

            Counter counter_p2 = new Counter() { Value = 10 };
            Console.WriteLine("Постфиксный инкремент");
            Console.WriteLine($"{counter_p2.Value}");
            Console.WriteLine($"{(counter_p2++).Value}"); 
            Console.WriteLine($"{counter_p2.Value}");

            Counter counter = new Counter() { Value = 5 };
            if (counter)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            Console.ReadKey();
        }
    }
}
