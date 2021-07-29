using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_13
{
    public class Admin : Users

    {
        private string role;

        public Admin (int age, string name, bool hasCar, book favbook, string role) 
            : base (age, name, hasCar, favbook)
        {
            this.role = role;
        }
    }
}
