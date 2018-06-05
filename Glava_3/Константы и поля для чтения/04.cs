using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Константы_и_поля_для_чтения
{    
    class MathLib
    {
        public const double PI = 3.14; //Константы - мы их можем объявить только 1 раз.
        public const double E = 2.71;  //К моменту компиляции они должны быть определены.
        /*
        public const double K; // ошибка - константа должна быть определена до компиляции
        public MathLib()
        {
            K = 2.5;// ошибка - константа должна быть определена до компиляции            
        }
        */
        
        //Поле для чтения объявляется с ключевым словом readonly 
        public readonly double M = 7; //можно так инициализировать
        public MathLib(double _m)
        {
            M = _m; // поле для чтения может быть инициализировано или изменено в конструкторе после компиляции
        }
        public void ChangeField()
        {
            // так нельзя
            //M = 34;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MathLib.E= 3;// константу нельзя установить несколько раз
            MathLib mathLib = new MathLib(3.8);
            Console.WriteLine(mathLib.M); // 3.8
            //mathLib.K = 7.6; // поле для чтения нельзя установить вне своего класса
            Console.ReadLine();
        }
    }

    
}
