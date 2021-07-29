using System;
using System.Collections.Generic;

namespace lessons_13
{
    class Program
    {
        static void Main(string[] args)
        {
            book thinkandGrow = new book(350, "Napaleon hill", "thinkandgrow", 1937);
            book world = new book(350, "Napaleon hill", "world", 1989);
            Users Alex = new Users(27,"Alex", true, thinkandGrow);
            Users Petr = new Admin(27, "Petr", true, world,"Editer");

            List<Users> people = new List<Users>();
            people.Add(Alex);
            people.Add(Petr);

            foreach (Users el in people)
            {
                Admin newobj = el as Admin;
                if (el is Admin)
                el.favbook.printBook();
            }
           
            Console.ReadKey();
        }
    }
}
