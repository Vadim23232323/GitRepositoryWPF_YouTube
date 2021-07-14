using System;

namespace lessons_3
{
    class Program
    {
        static void Main(string[] args)
        {
            short num;
            bool hasCar = true;
            string str, name;

            Console.WriteLine("Enter one number");
            num = Convert.ToInt16(Console.ReadLine());

            if (num == 10)
                Console.WriteLine("the number is exactly 10");

            else if (num > 50)
                Console.WriteLine("the number is greater 50");
            else
                Console.WriteLine("the number unknow");

            str = num < 100 && hasCar && num==54 ? "Yes" : "No";
            Console.WriteLine(str);

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            switch (name)
            {
                case "Vadim":
                    Console.WriteLine("Registration renewed");
                        break;
                case "Nikolay":
                    Console.WriteLine("registration denied");
                    break;
            }

            Console.ReadKey();
        }
    }
}
