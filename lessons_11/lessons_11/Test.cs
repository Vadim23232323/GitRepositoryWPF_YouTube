using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_11
{
    public class Test<T, T2>

    {
        public T field;
        public T2 field_2;

        public Test(T field, T2 field_2)
        {
            this.field=field;
            this.field_2=field_2;

            Console.WriteLine($"T: {field} , T2: {field_2}");
        }
    }
}
