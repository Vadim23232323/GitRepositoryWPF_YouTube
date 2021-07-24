using System;

namespace lessons_8
{
    class Program
    {
        static void Main(string[] args)
        {

            // Выделяем место для создонных обьектов, вводим и выводим даннеы на экран

            Users alex = new Users();

            alex.age = 45;
            alex.email = "test@mail.ru";
            alex.name = "Alexey";


            Users admin = new Users();

            admin.setAdmin("Administrator");
            admin.age = 27;
            admin.email = "admin@mail.ru";
            admin.name = "Administrator";

            Console.WriteLine("Role : " + admin.administrator.role);
            Console.WriteLine("Name : " + alex.name);
            Console.WriteLine("Name : " + admin.name);


            // Выделяем место для создонных обьектов, вводим и выводим даннеы через методы класса Users

            Users Vadim = new Users();

            Vadim.setAll("Vadim", "Vadmin@mail.ru", "711111111", 27);
            Vadim.setEmail("Vadim@gmail.com");
            Vadim.printAll();


            Console.ReadKey();
        }
    }

}
