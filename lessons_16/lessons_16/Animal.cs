using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_16
{
        [Serializable]
        public class Animal
        {
            public int age;
            public string name;

            [NonSerialized]
            public string category;

            public Animal()
            {

            }

            public Animal(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        }
    }
