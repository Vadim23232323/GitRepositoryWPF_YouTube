using System;

namespace lessons_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выделяем место для создонных обьектов, вводим и выводим даннеы на экран

            Users alex = new Users("Vadim", "Vadmin@mail.ru", "711111111", -2);

            Users sergey = new Users("Sergey", "Vadmin@mail.ru", "711111111", 27);

            Admin admin = new Admin("Egor","admin@mail.ru","8888", 29, "Admininstrator");

            admin.printAll();

            Users.ptint();

            Car bmw = new Car(250.5f);
            Console.WriteLine($"Speed: {bmw.getSpeed()}");

            Car.Engine bmwEngine = new Car.Engine();
            bmwEngine.startEngine(true);
            Console.WriteLine($"Engine started: {bmwEngine.getIsStart()}");

            Console.ReadKey();
        }
    }
}
