using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Параметры_методов
{
    class Program
    {
        static void Main(string[] args)
        {
            //передача параметров по значению
            int x = 2;
            int z = Sum(x, 4);
            Console.WriteLine(z);
            Console.ReadKey();
            //передача папаметров по ссылке
            //(При передаче по значению метод получает не саму переменную, а ее копию. 
            //А при передаче параметра по ссылке метод получает адрес переменной в памяти. )
            int xx = 7;
            int yy = 8;
            //Модификатор ref
            //При передаче параметров по ссылке перед параметрами используется модификатор ref
            Add(ref xx, yy);
            Console.WriteLine(xx);
            Console.ReadKey();
            //Модификатор out
            //Чтобы сделать параметр выходным, перед ним ставится модификатор out
            SAD(3, 4, out int r);
            Console.WriteLine(r);
            Console.ReadKey();
            //Прелесть использования подобных параметров состоит в том, 
            //что по сути мы можем вернуть из метода не один вариант, а несколько. Пример:
            int t = 10;
            int area;
            int perimetr;
            GetData(t, 15, out area, out perimetr);
            Console.WriteLine("Периметр: " + perimetr);
            Console.WriteLine("Плащадь: " + area);
            Console.ReadKey();
            /*
            Именованные параметры
            В предыдущих примерах при вызове методов значения для параметров передавались в порядке 
            объявления этих параметров в методе. Но мы можем нарушить подобный порядок, 
            используя именованные параметры.
            */
            int bb=Retyw(j: 4, g: 1,l:2); //мы передаем j=4
            //Необязательный параметр p использует значение по умолчанию
            Console.WriteLine(bb);
            Console.ReadKey();

        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Add(ref int xx, int yy)
        {
            xx = xx + yy;
        }
        static void SAD(int q, int w, out int e)
        {
            e = q + w;
        }
        static void GetData(int u, int i, out int area, out int perim)
        {
            area = u * i;
            perim = (u + i) * 2;
        }
        //Стоит отметить, что в версии C# 7.0 (Visual Studio 2017) можно определять 
        //переменные в непосредственно при вызове метода. 
        /*
        ---То есть вместо:
        int x = 10;
        int area;
        int perimetr;
        GetData(x, 15, out area, out perimetr);
        Console.WriteLine("Площадь : " + area);
        Console.WriteLine("Периметр : " + perimetr);
        ---Мы можем написать:
        int x = 10;
        GetData(x, 15, out int area, out int perimetr);
        Console.WriteLine("Площадь : " + area);
        Console.WriteLine("Периметр : " + perimetr);
        */
        static int Retyw(int g, int j, int l = 4, int p = 7)
        {
            return g + j + l + p;
        }
    }
}
