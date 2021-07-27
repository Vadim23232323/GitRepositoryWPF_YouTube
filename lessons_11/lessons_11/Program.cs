using System;

namespace lessons_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");

            Humans Alex = new People();

            Humans Zorg = new UFO();

            Alex.sayHello();
            Zorg.sayHello();

            Alex.talk();
            Zorg.talk();

            Test<int,string> obj_1 = new Test<int,string>(23,"Type");
            //obj_1.field = 23;
            //obj_1.field_2 = "Type";

            Test<int,char> obj_2 = new Test<int, char>(26,'t');
            //obj_1.field = 26;
            //obj_2.field_2 = 't';

            Console.ReadKey();
        }
    }
}
