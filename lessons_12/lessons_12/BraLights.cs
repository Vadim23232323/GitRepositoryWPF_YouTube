using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_12
{
    class BraLights : Ilights, ILightProblems
    {
        public float brightness { get ; set ; }
        public bool isOn { get; set; }
        public Lights type { get; set; }

        public void ElectricError()
        {
            Console.WriteLine("Problem electric");
        }

        public bool isLightOn()
        {
            string isOnLight = isOn ? "Enable" : "disable";
            Console.WriteLine("Light status: " + isOnLight);
            return isOn;
        }

        public void turnOnOff(bool isOn)
        {
            this.isOn = isOn;
        }
    }
}
