using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Статические_члены_и_модификатор_static
{
    class Program2
    {
        static void Main2(string[] args)
        {
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            User.DisplayCounret();
            Console.ReadKey();
        }
    }
    class User
    {
        private static int counter = 0;
        public User()
        {
            counter++;
        }
        public static void DisplayCounret()
        {
            Console.WriteLine($"Создано {counter} объевтов User");

        }
    }
    
    
}
