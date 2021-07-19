using System;
using System.Collections;
using System.Collections.Generic;

namespace lessons_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 0, 3, 5, 7, 1, 4 };
            int[] cash = { 5, 10, 20, 50, 100, 500 };

            short[] number_1 = { 7, 6, 5, 3, 2, 1 };
            short[] cash_1 = { 500, 100, 50, 20, 10, 5 };

            ArrayList arli = new ArrayList();
            arli.Add(33);
            arli.Add("Tatia");
            arli.Add('3');

            Console.WriteLine("Print ArrayList");

            Console.WriteLine(arli.Count);
            foreach(object el in arli)
            {
                Console.WriteLine(el);
            }


            Dictionary<string, char> dict = new Dictionary<string, char>();
            dict.Add("long", 'b');
            dict.Add("rus", 'r');
            dict.Add("cpp", 'c');

            dict.TryGetValue("rus", out char exmple);
            Console.WriteLine(exmple);

            foreach  (KeyValuePair<string, char> el in dict)
            {
                Console.WriteLine($"Key : {el.Key}, Value : {el.Value}");
            }
            {

            }

            Console.WriteLine("");

            int max = 0;
            maxElement(number, out max);

            Console.WriteLine("Max element array {0} ", max);

            print("Tatia ", 24);

            print();

            int c = 3, d = 7;

            int result = summ(c, d);

            print("Summa", result);

            PrintArrays<int>(ref number, ref cash);

            PrintArrays<short>(ref number_1, ref cash_1);

            summAll(1, 4, 6, 6);

            Console.ReadKey();
        }

        public static void summAll(params int[] nums)
        {
            int sum = 0;

            foreach (int el in nums)
            {
                sum += el;
                Console.WriteLine("");
                Console.WriteLine("Result -  {0} " , sum);
            }
        }

        public static void print(string name = "Enter name", int age = 18)
        {
            Console.WriteLine("Name : {0}, Age : {1}", name, age);
        }

        public static int summ(int a = 5, int b = 6)
        {
            int res = a + b;
            return res;

        }

        public static void maxElement(int[] num, out int max)
        {
            max = num[0];
            foreach (int el in num)
            {
                if (el > max)
                    max = el;
            }
        }

        public static void changeArrays<T>(ref T[] a, ref T[] b)
        {
            T[] temp = new T[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);
            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);
            temp.CopyTo(b, 0);
        }

        public static void PrintArrays<T>(ref T[] number, ref T[] cash)
        {
            foreach (T elemets in number)
                Console.Write("{0} ", elemets);
            Console.WriteLine("");
            foreach (T elemets in cash)
                Console.Write("{0} ", elemets);

            changeArrays(ref number, ref cash);
            Console.WriteLine("");

            foreach (T elemets in number)
                Console.Write("{0} ", elemets);
            Console.WriteLine("");
            foreach (T elemets in cash)
                Console.Write("{0} ", elemets);
        }
    
    }
}
