using System;

namespace lessons_12
{
    class Program
    {
        static void Main(string[] args)

        {
            BraLights bra = new BraLights();
            bra.type = Lights.Bra;

            bra.turnOnOff(true);
            bool isOnBra = bra.isLightOn();
            bra.turnOnOff(false);
            isOnBra = bra.isLightOn();

            Console.ReadKey();
        }
    }
}
