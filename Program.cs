using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Library Management System ****");
            Library l = new Library();
            Console.WriteLine("\n****    User  or  Libararian  (U / L)    ****\n");
            char input1 = Console.ReadLine().ToUpper()[0];
            if (input1 == 'L')
            {
                Librarian lu = new Librarian();
                Console.WriteLine($"***** HELLO {lu.Name} ****(As a Librarian)*\n" +
                    $"Your Login Registration Operation CREATED\n");
                Console.WriteLine($"**********  | Control Panel |**********\n \n" +
                        $"For Adding Books  --> (A) \n\n" +
                        $"For Remove Books  --> (R) \n\n" +
                        $"For Display Books --> (D) \n" +
                        $"any key for exit mode ");
                while (true)
                {
                    char input2 = Console.ReadLine().ToUpper()[0];
                    switch (input2)
                    {
                        case 'A':
                            if (l.Bookcount <= 99)
                            {
                                Book book1 = new Book();
                                Console.Write("--- Give me details ---\n" +
                                    "Title : ");
                                book1.Title = Console.ReadLine();
                                Console.Write("Author : ");
                                book1.Author = Console.ReadLine();
                                Console.Write("Year : ");
                                book1.Year = int.Parse(Console.ReadLine());
                                Console.WriteLine("Book is added successfully");
                                lu.Add(book1, l);
                                Console.WriteLine("\nany anther key for exit mode");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("The library is FULL");
                                break;
                            }
                        case 'R':
                            Book book2 = new Book();
                            Console.Write("--- Give me details ---\n" +
                                "Title : ");
                            book2.Title = Console.ReadLine();
                            Console.Write("Author : ");
                            book2.Author = Console.ReadLine();
                            Console.Write("Year : ");
                            book2.Year = int.Parse(Console.ReadLine());
                            Console.WriteLine("Book is removed successfully");
                            Console.WriteLine("\nany anther key for exit mode");

                            lu.Remove(book2, l);
                            break;
                        case 'D':
                            lu.List(l);
                            Console.WriteLine("list ended");
                            Console.WriteLine("\nany anther key for exit mode");
                            break;
                        default:
                            Console.WriteLine($"Bye {lu.Name}");
                            return;
                    }

                }
            }
            else if (input1 == 'U')
            {
                Console.WriteLine("***** Login ****(As a User)*\n");
                Console.Write("Enter Your Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Your Age : ");
                int age = int.Parse(Console.ReadLine());
                NormalUser nu = new NormalUser(name, age);
                Console.WriteLine($"***** HELLO {nu.Name} *****\n" +
                    $"Your Login Registration Operation CREATED\n");
                UserCard uc = new UserCard();
                uc.DisplayCard(nu, l);
                Console.WriteLine($"\n**********  | Control Panel |**********\n \n" +
                        $"For Borrowing Books  --> (B) \n\n" +
                        $"For Display Books --> (D) \n\n" +
                        $"For Show Your Card  --> (S) \n" +
                        $"                      Any key for exit mode ");



                while (true)
                {
                    char input3 = Console.ReadLine().ToUpper()[0];
                    switch (input3)
                    {
                        case 'B':
                            Book book = new Book();
                            nu.borrow(book, l);
                            Console.WriteLine("\n         any anther key for exit mode");
                            break;
                        case 'D':
                            l.ListBorrowedBooks();
                            Console.WriteLine("list ended");
                            Console.WriteLine("\n         any anther key for exit mode");
                            break;
                        case 'S':
                            uc.DisplayCard(nu, l);
                            break;
                        default:
                            Console.WriteLine($"Bye {nu.Name}");
                            return;
                    }
                }
            }
        }
    }
}
