using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    class Password_Par_Func
    {
        private string password = "test";
        public string Password
        {
            get { return password; }
            set
            {
                if (value == password)
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }
        public void PasswordChck()
        {
            bool flag2 = false;
            bool flag = false;
            while (flag == false)
            {
                string att = Console.ReadLine();
                flag2 = false;
                try { Password = att; }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Leo does not permit");
                    flag2 = true;
                }
                if (flag2 == false)
                {
                    flag = true;
                }
            }
            Console.WriteLine("Accepted");   
        }
        public void intset(string pass)
        {
            password = pass;
        }

    } 
}
