using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_11
{
    class UFO : Humans
    {
        public override void talk()
        {
            Console.WriteLine("PiPi");
        }

        public override void walk()
        {
            Console.WriteLine("Air");
        }
    }
}
