using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_10
{
    class Car
    {
        protected float speed;

        public Car(float speed)
        {
            this.speed = speed;
        }

        public float getSpeed()
        {
            return speed;
        }

        public class Engine
        {
            private bool isStart;

            public void startEngine(bool isStart)
            {
                this.isStart = isStart;
            }

            public bool getIsStart()
            {
                return isStart;
            }
        }
    }
}
