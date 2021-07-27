using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_11
{
    class People : Humans

    {
        public override void sayHello()
        {
            // base.sayHello(); 
            Console.WriteLine("Hello world");
        }
        public override void talk()
        {
            Console.WriteLine("Hi");
        }

        public override void walk()
        {
            Console.WriteLine("Step");
        }
    }
}
