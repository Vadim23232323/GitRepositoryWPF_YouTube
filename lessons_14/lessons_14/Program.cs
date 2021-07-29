using System;
using System.Collections.Generic;
using System.Linq;

namespace lessons_14
{
    class Program

    {
        delegate void Message();

        delegate int Math(int x, int y);

        delegate float SquareNumber(float number);

        static void Main(string[] args)
        {
            SquareNumber square = x => x * x;

            Console.WriteLine("10 ^ 2 = " +square(10));

            //  List<short> numbers = new List<short>() { 5, 6, 7, 22, 55, 23, 23, 3 };

            List<int> numbers = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 14; i++)
            {
                numbers.Add(rnd.Next(1, 10));
            }


            var list = numbers.Where(x => (x > 3) && (x<12)).ToList();

            foreach (var el in list)
            {
                Console.WriteLine(el);
            }

            List<int> peoples = new List<int>();

            peoples.AddRange(Enumerable.Range(1, 10));

            int sum = peoples.Aggregate((x, y) => x + y);

            Console.WriteLine($"Summa elementov : {sum}");

            var squares = peoples.Select(x => x * x);

            foreach (var element in squares)
            {
                Console.WriteLine(element);
            }


            List<int> digits = new List<int>();

            digits.AddRange(Enumerable.Range(11, 20));

            var groupAndMult = peoples.Zip(digits, (x, y) => x * y);

            foreach (var element in groupAndMult)
            {
                Console.WriteLine(element);
            }

            List<string> words = new List<string> { "word", "hello", "hi", "word" };
            string result = string.Join(", ", words.Distinct());
            Console.WriteLine(result);

            Message msg;

            if (DateTime.Now.Hour<12)
            {
                msg = goodMorning;
            } else
            {
                msg = goodDay;
            }

            msg();

            Math operation = Add;

            Console.WriteLine(operation(5,7));

            operation = Mult;

            Console.WriteLine(operation(5, 7));

            Console.ReadKey();
        }

        private static int Mult(int x, int y)
        {
            return x * y;
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void goodMorning()
        {
            Console.WriteLine("Good morning");
        }

        private static void goodDay()
        {
            Console.WriteLine("Good day");
        }
    }
}
