using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_8
{


    public class Users
    {
        public string name;
        public string email;
        public string password;
        public byte age;
        public Admin administrator = new Admin();

        public void setAll(string _name, string _email, string _pass, byte _age)
        {
            name = _name;
            email = _email;
            password = _pass;
            age = _age;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }

        public void setAdmin(string role)
        {
            administrator.role = role;
        }

        public void printAll()
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Password: {password}, Age: {age}");
        }
    }
}

