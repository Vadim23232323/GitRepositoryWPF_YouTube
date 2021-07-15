using System;
using System.Collections.Generic;

namespace lessons_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cycle FOR: ");

            for (byte i = 0; i <= 10; i++)
            {
                Console.WriteLine("Element - " + i);
            }

            Console.WriteLine("");
            Console.WriteLine("Cycle WHILE: ");

            byte j = 0;

            while (j <= 10)
            {
                Console.WriteLine("Element - " + j);
                j++;
            }

            Console.WriteLine("");
            Console.WriteLine("Cycle DO WHILE:");

            j = 100;

            do
            {
                Console.WriteLine("Element - " + j);
            }
            while (j < 100);

            Console.WriteLine("");
            Console.WriteLine("Cycle FOR with if: ");

            for (byte i = 1; i <= 40; i++)
            {
                if (i >= 36)
                    break;

                if (i % 2 != 0)
                    continue;
                Console.WriteLine("Element - " + i);
            }

            Console.WriteLine("");
            Console.WriteLine("Array with Cycle FOR : ");

            int[] numbers = { 2, 3, 6, 8, 9 };
            int summa = 0;

            for (byte i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine("");
            Console.WriteLine("Summa elementov array with Cycle FOR : ");
            for (byte i = 0; i < numbers.Length; i++)
                summa += numbers[i];
            Console.WriteLine("Summ elementov array " + summa);

            Console.WriteLine("");
            Console.WriteLine("Array print: ");

            int[,] people = {
                {2, 4, 4},
                {4, 8, 9},
                {5, 1, 4}};

            for (byte i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write(" " + people[i, j]);
                Console.WriteLine(" ");
            }

            Console.WriteLine("");
            Console.WriteLine("Cycle FOREACH: ");

            string[] names = { "Denis", "Marta", "Tatia" };

            foreach (string element in names)
                Console.WriteLine(" " + element);

            Console.WriteLine("");

            List<string> cars = new List<string>() { "Citroen", "Opel", "BMW" };
            
            foreach (string element in cars)
                Console.WriteLine(" " + element);

            Console.WriteLine("");
            Console.WriteLine("Games: ");

            byte rand = 8, user_input;

            do
            {
                Console.Write("Enter numbers in 1 to 10: ");
                user_input = Convert.ToByte(Console.ReadLine());
            } while (user_input != rand);
            Console.WriteLine("Victory!!! ");
                

            Console.ReadKey();
        }
    }
}
