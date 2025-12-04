using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class UserCard
    {
        private string name;

        public void DisplayCard(NormalUser u_, Library l)
        {
            Console.WriteLine("**********************************\n" +
                              "********  User Card        *******");
            Console.WriteLine($"* Name : {u_.Name}              ");
            Console.WriteLine($"* Age : {u_.Age}                   ");
            Console.WriteLine($"*                  Status Active ");
            Console.WriteLine("* _________________________");
            Console.WriteLine("* Books are Borrowed : " + l.BorrowedBookcount + "      *");
        }
    }
}
