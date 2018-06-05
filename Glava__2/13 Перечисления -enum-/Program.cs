using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Перечисления__enum_
{
    class Program
    {
        /*
         * В этих примерах каждому элементу перечисления присваивается целочисленное значение, 
         * причем первый элемент будет иметь значение 0, второй - 1 и так далее. 
         * Мы можем также явным образом указать значения элементов, либо указав значение первого элемента.
         * */
        enum Operation
        {
            Add = 1 ,
            Subtract,
            Multiply,
            Divide
        }
        static void MathOp(double x, double y, Operation op,  out string tip)
        {
            double result = 0.0;
            tip = "";
            switch (op)
            {
                case Operation.Add:
                    tip = "сложения";
                    result = x + y;
                    break;
                case Operation.Subtract:
                    tip = "вычитания";
                    result = x - y;
                    break;
                case Operation.Multiply:
                    tip = "умножения";
                    result = x * y;
                    break;
                case Operation.Divide:
                    tip = "деления";
                    result = x / y;
                    break;
            }
            Console.WriteLine("Результат операции {1} над числами {2} и {3} равен {0}", result, tip, x, y);
        }
        static void Main(string[] args)
        {
            //string tip;
            // Тип операции задаем с помощью константы Operation.Add, которая равна 1
            MathOp(10, 5, Operation.Add,out string tip);
            // Тип операции задаем с помощью константы Operation.Multiply, которая равна 3
            MathOp(11, 5, Operation.Multiply, out tip);
            MathOp(12, 2, Operation.Subtract, out tip);
            MathOp(14, 2, Operation.Divide, out tip);
            Console.ReadLine();
        }
    }
}
