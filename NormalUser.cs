using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class NormalUser : User
    {
        public NormalUser(string n, int a)
        {
            base.Name = n;
            base.Age = a;
        }

        public void borrow(Book _book, Library l)
        {
            Console.Write("--- Give me details ---\n" +
                                    "Title : ");
            string input1 = Console.ReadLine();
            Console.Write("Author : ");
            string input2 = Console.ReadLine();
            Console.Write("Year : ");
            int input3 = int.Parse(Console.ReadLine());
            _book.Title = input1;
            _book.Author = input2;
            _book.Year = input3;
            l.borrow(_book);
        }
        public void Listbooks(Library l)
        {
            l.ListBooks();
        }
        public void Listborrowedbooks(Library l)
        {
            l.ListBorrowedBooks();
        }
    }
}
