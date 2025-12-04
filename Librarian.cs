using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Librarian : User
    {
        public Librarian()
        {
            Console.WriteLine("***** Login *****\n");
            Console.Write("Enter Your Name : ");
            base.Name = Console.ReadLine();
            Console.Write("Enter Your Age : ");
            base.Age = int.Parse(Console.ReadLine());
        }
        public void Add(Book book, Library l)
        {
            l.Add(book);
        }
        public void Remove(Book book, Library l)
        {
            l.Remove(book);
        }
        public void List(Library l)
        {
            l.ListBooks();
        }
    }
}
