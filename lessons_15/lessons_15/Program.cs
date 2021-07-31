using System;
using System.Threading;

namespace lessons_15
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread tr = Thread.CurrentThread;

            //Console.WriteLine(tr.Name);
            //tr.Name = "Main stream";
            //Console.WriteLine(tr.Name);
            //Console.WriteLine(tr.Priority);
            //Console.WriteLine(tr.ThreadState);
            //Console.WriteLine(tr.IsAlive);
            //Console.WriteLine(Thread.GetDomain().FriendlyName);


            //ThreadStart ts = new ThreadStart(printSome);
            //Thread myTr = new Thread(ts);
            Numbers num = new Numbers(5, 6);
            Thread myTr = new Thread(new ThreadStart(num.printSome));
            myTr.Start(num);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main strem");
                Thread.Sleep(300);
            }


            Console.ReadKey();
        }

    }
}
