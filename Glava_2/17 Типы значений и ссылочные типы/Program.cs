﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Типы_значений_и_ссылочные_типы
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State(); //Структура, ее данные в стеке              
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state1 = state2;
            state2.x = 5; // state1.x=1 по-прежнему
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5


            Country country1 = new Country(); //класс, в стек помещаются ссылка на адрес в хипе, а в хипе располдогаются все даные объекта                                                       
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 4;
            country1 = country2;
            country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
                            // указывают на один объект в хипе
            Console.WriteLine(country1.x); // 7
            Console.WriteLine(country2.x); // 7

            Console.Read();

        }
    }
    struct State
    {
        public int x;
        public int y;
    }
    class Country
    {
        public int x;
        public int y;
    }
}
