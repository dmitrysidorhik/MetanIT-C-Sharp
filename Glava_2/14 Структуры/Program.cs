using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book; //структура
            book.name = "Война и мир";
            book.author = "Толстой";
            book.year = 1869;
            book.Info();
            //--------------------------------------------------------
            Books [] books= new Books[3]; //массив структур
            books[0].name = "Война и мир";
            books[0].author = "Л. Н. Толстой";
            books[0].year = 1869;
            books[1].name = "Преступление и наказание";
            books[1].author = "Ф. М. Достоевский";
            books[1].year = 1866;
            books[2].name = "Отцы и дети";
            books[2].author = "И. С. Тургенев";
            books[2].year = 1862;
            foreach (Books b in books)
            {
                b.Info();
            }
            Console.ReadKey();
            //----------------------------------------------------
            BooksConstructor bookconst = new BooksConstructor("Книга", "Тот", 1000);
            bookconst.Info();
            Console.ReadKey();
        }
    }
    //Структуры могут содержать в себе обычные переменные и методы
    struct Book
    {
        //Структуру можно задать как внутри пространства имен, так и внутри класса, но не внутри метода.
        public string name;
        public string author;
        public int year;
        public void Info()
        {
            Console.WriteLine("Книга: {0} Автор: {1} Год: {2}", name, author, year);
        }
    }
    // Мы также можем использовать массив структур:
    struct Books
    {
        public string name;
        public string author;
        public int year;
        public void Info()
        {
            Console.WriteLine("Книга: {0} Автор: {1} Год: {2}", name, author, year);
        }
    }
    //Конструкторы в структурах
    //Кроме обычных методов структура может содержать специальный метод - конструктор, 
    //который выполняет некую начальную инициализацию объекта, например, присваивает 
    //всем полям некоторые значения по умолчанию
    struct BooksConstructor
    {
        public string name;
        public string author;
        public int year;
        //конструктор
        public BooksConstructor(string n, string a, int y)
        {
            name = n;
            author = a;
            year = y;
        }
        public void Info()
        {
            Console.WriteLine("Книга {0} Автор {1} Год {2}", name, author, year);
        }
    }
}
