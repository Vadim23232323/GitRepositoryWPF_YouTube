using System;

namespace lessons_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte age, a = 0, b = 0;
            int res;

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("My name " + name + " i am " + age + " years old");

            Console.WriteLine("Enter a: ");
            a = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Result: " + (a+b).ToString());
            Console.Read();
        }
    }
}
