using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cinema task
            //Hall hall1 = new Hall("Titan", 2, 3);
            ////hall1.Reserve(1,1);
            ////hall1.Reserve(1, 1);

            //Hall hall2 = new Hall("Jupiter", 2, 2);
            //Hall hall3 = new Hall("Pluton", 2, 2);

            //Cinema cinema = new Cinema(2, "Ibrahim");
            //cinema.AddHall(hall1);
            //cinema.AddHall(hall2);
            //cinema.AddHall(hall3);
            #endregion

            #region Extentions
            //string name = "Memmed@mail.ru";
            //Console.WriteLine(name.isMail());

            //int x = 5;
            ////Console.WriteLine(Power(x, 2));
            //Console.WriteLine(x.Power(2));

            //Person p = new Person();
            //p.Test();
            #endregion

            Library lib = new Library();
            Book book = new Book() { Name="Xemse"};

            lib[0] = book;
            Console.WriteLine(lib[0]);

            int? x = null;

            object t = "Memmed";
            string z = (string)t;
            //Test test = new Test();
        }
    }

    //public sealed class Test { }

    //class Test1 : Test { }

    //public class Person { }
    public class Library
    {
        static int index = 0;
        public string Name { get; set; }

        public string Address { get; set; }

        private Book[] books;

        public Book this[int i]
        {
            get 
            {
                return books[i];
            }
            set 
            {
                books[i] = value;
            }
        }

        public Library()
        {
            books = new Book[100];
        }

        public void AddBook(Book book)
        {
            books[index] = book;
            index++;
        }

    }

    public class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
