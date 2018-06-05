using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Interface1
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int Sum);
    }
}
