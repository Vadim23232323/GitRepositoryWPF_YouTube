using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_10
{
    public class Admin : Users
    {
        private string role;

        public Admin(string name, string email, string password, sbyte age, string role)
        : base(name, email, password, age) {
                this.role = role;
        }

        public void getRole()
        {
            Console.WriteLine($"Role : {role}");
        }

        public override void printAll()
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Password: {password}, Age: {Age}, Role: {role}");
        }
    }
}

