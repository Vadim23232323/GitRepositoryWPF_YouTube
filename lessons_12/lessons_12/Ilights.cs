using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_12
{
    public interface Ilights
    {
        float brightness { get; set; }
        bool isOn { get; set; }

        Lights type { get; set; }

        void turnOnOff(bool isOn);

        bool isLightOn();

    }
}
