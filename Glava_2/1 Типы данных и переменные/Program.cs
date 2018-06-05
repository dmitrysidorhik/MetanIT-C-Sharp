using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Типы_данных_и_переменные
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var stroka = "ssdf";
            var dec = 35.3f;
            var gt = 23.43;
            var df = 343.43m;
            var i = 1;
            var simv = 'f';
            Console.WriteLine(stroka.GetType().ToString());
            Console.WriteLine(dec.GetType());
            Console.WriteLine(gt.GetType());
            Console.WriteLine(df.GetType());
            Console.WriteLine(i.GetType());
            Console.WriteLine(simv.GetType());
            Console.ReadKey();
        }
    }
}
