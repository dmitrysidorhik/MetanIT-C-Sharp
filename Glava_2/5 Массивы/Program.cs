using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            //тоже самое int[] nums1 = new int[5] { 1, 2, 3, 4, 5 };
            int[,] nums2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            //тоже будет работать   int[,] nums2 ={ { 1, 2, 3 }, { 4, 5, 6 } };
            int[,,] nums3 = new int[2,3,4];

            // Массив массивов
            // От многомерных массивов надо отличать массив массивов или так называемый "зубчатый массив":
            int[][] nums = new int[3][];
            nums[0] = new int[2];
            nums[1] = new int[3];
            nums[2] = new int[5];
            //Здесь две группы квадратных скобок указывают, что это массив массивов, 
            //то есть такой массив, который в свою очередь содержит в себе другие массивы. 
            //В данном случае у нас массив nums содержит три массива. Причем размерность 
            //каждого из этих массивов может не совпадать.
            
            //Причем мы можем использовать в качестве массивов и многомерные:                        
            int[][,] nums_ = new int[3][,]
            {
                new int[,] { {1,2}, {3,4} },
                new int[,] { {1,2}, {3,6} },
                new int[,] { {1,2}, {3,5}, {8, 13} }
            };

            int[] der = new int[] { 3, 7, 1, 3, 0, 8, 2, 9, 5, 3, 7, 2, 2, 5 };
            int length_der = der.Length;
            Console.WriteLine(length_der); //длина
            int rank_der = der.Rank; 
            Console.WriteLine(rank_der); //размерность
            Array.Reverse(der); //изменяет порядок следования элементов массива на обратный
            Console.WriteLine(der[0]+" "+der[1]+" "+der[2]); 
            Array.Sort(der); //сортирует элементы массива
            Console.WriteLine(der[0] + " " + der[1] + " " + der[2]);
            Console.ReadKey();



        }
    }
}
