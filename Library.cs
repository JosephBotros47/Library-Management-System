using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        // fields
        private Book[] books = new Book[100];
        private Book[] Borrowedbooks = new Book[50];
        private int bookcount = 0;
        private int borrowedBookcount = 0; 
        public int Bookcount
        {
            get { return bookcount; }
            set { bookcount = value; }
        }
        public int BorrowedBookcount
        {
            get { return borrowedBookcount; }
            set { borrowedBookcount = value; }
        }

        // methods 
        public void Add(Book book)
        {
            this.books[this.bookcount] = book;
            this.bookcount++;
        }
        public void Remove(Book book)
        {
            for (int i = 0; i < bookcount; i++)
            {
                if (book != null && book.Title == books[i].Title)
                {
                    Console.WriteLine(book.Title + " is removed");
                    books[i] = null;
                    bookcount--;
                    for (int j = i; j < bookcount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("You might set invalid title");
                }
            }
        }
        public void ListBooks()
        {
            for (int i = 0; i < bookcount; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine($"Book : {books[i].Title}\n his Author : " +
                    $"{books[i].Author} \n Year : {books[i].Year}");
                }
                else
                    continue;
            }
        }
        public void borrow(Book book_)
        {
            Borrowedbooks[borrowedBookcount] = book_;
            this.Remove(book_);
            borrowedBookcount++;
        }
        public void ListBorrowedBooks()
        {
            for (int i = 0; i < borrowedBookcount; i++)
            {
                if (Borrowedbooks[i] != null)
                {
                    Console.WriteLine($"Book : {Borrowedbooks[i].Title}\n his Author : " +
                    $"{Borrowedbooks[i].Author} \n Year : {Borrowedbooks[i].Year}");
                }
                else
                    continue;
            }
        }
    }
}
