using System;
using System.Collections.Generic;

namespace lessons_4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] mas = new byte[5];

            mas[0] = 27;

            Console.WriteLine(mas[0]);

            string[] students = new string[] { "Tatia", "Sergey", "Maksim", "Egor", "Vadim" };

            Console.WriteLine(students[0]);

            int[] numbers = { 5, 2, 500, 76, 80 };

            int[,] people = { { 5, 8, 6 }, { 5, 8, 6 }, { 5, 8, 6 } };

            Console.WriteLine(people[1, 1]);

            people[1, 1] = 50;

            Console.WriteLine(people[1, 1]);

            Console.WriteLine("array length" + people.Length);

            Array.Clear(people, 2, people.Length);

            int[] copyPeople = new int[people.Length];
            people.CopyTo(copyPeople, 0);

            Console.WriteLine(copyPeople[1]);

            List<short> digits = new List<short>() { 1, 0, 93, 75 };
            digits.Add(5);
            digits.AddRange(new short[] { 7, 8, 45 });
            digits.Insert(1, 178);
            digits.Remove(0);
            digits.RemoveAt(2);
            digits.Sort();
            Console.WriteLine(digits[2]);


            Console.ReadKey();

        }
    }
}
