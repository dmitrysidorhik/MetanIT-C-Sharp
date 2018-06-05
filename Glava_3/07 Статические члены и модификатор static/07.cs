using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Статические_члены_и_модификатор_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Account.MinSum = 560;
            decimal result = Account.GetSum(12, 34, 56);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    class Account
    {
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum)
            {
                throw new Exception("Недопстимая сумма");
            }
            Sum = sum;
            Rate = rate;       
        }
        private static decimal minSum = 100;
        public static decimal MinSum
        {
            get
            {
                return minSum;
            }
            set
            {
                if (value > 0) minSum = value;
            }
        }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }

        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }
}
