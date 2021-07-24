using System;

namespace lessons_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выделяем место для создонных обьектов, вводим и выводим даннеы на экран

            Users alex = new Users("Vadim", "Vadmin@mail.ru", "711111111", -2);

            Users admin = new Users("Sergey", "Vadmin@mail.ru", "711111111", 27, "Admin");

            //alex.printAll();
            //admin.printAll();
            Console.WriteLine(admin.getAdminRole());
            //Console.WriteLine(Users.count);
            Users.ptint();


            Console.ReadKey();
        }
    }
}
