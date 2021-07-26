using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_10
{
    public class Users
    {
        protected string name;
        protected string email;
        protected string password;
        private sbyte age;

        public sbyte Age
        {
            get
            {
                age++;
                return age;
            }
            set
            {
                if (value < 0)
                    this.age = 1;
                else
                    age = value;
            }
        }
       
        public static int count;

        public Users(string name, string email, string pass, sbyte age)
        {
            this.name = name;
            this.email = email;
            this.password = pass;
            Age = age;

            printAll();

            count++;
        }

 

        public void setAll(string _name, string _email, string _pass, sbyte _age)
        {
            name = _name;
            email = _email;
            password = _pass;
            Age = _age;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }

        public virtual void printAll()
        {
            Console.WriteLine($"Name: {name}, Email: {email}, Password: {password}, Age: {Age}");
        }

        public static void ptint()
        {
            Console.WriteLine($"number of users : {count}");
        }
    }
}
