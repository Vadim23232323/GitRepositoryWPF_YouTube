using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lessons_15
{
    public class Numbers { 
    public int x, y;
    public Numbers(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void printSome()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("My stream - " + x + ", " + y);
                Thread.Sleep(300);
            }
        }
    }
}
