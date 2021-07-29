using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_13
{
   public class Users
    {
        private int age;
        private string name, surname, email;
        private bool hasCar;
        public book favbook;

        public Users (int age, string name, bool hasCar, book favbook)
        {
            this.age = age;
            this.name = name;
            this.hasCar = hasCar;
            this.favbook = favbook;

        }
    }
}
