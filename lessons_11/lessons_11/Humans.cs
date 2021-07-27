using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_11
{
    public abstract class Humans
    {
        public virtual void sayHello ()
        {
            Console.WriteLine("None");
        }

        public abstract void talk();
        public abstract void walk();

    }
}
