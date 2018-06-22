using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password
{
    public class PasswordIncorrectException : Exception
    {
        public PasswordIncorrectException()
        {
        }
        public PasswordIncorrectException(string message)
            : base(message)
        {
        }
        public PasswordIncorrectException(string message, Exception inner)
            : base(message)
        {
        }
    } 
    class Password_Par_Func
    {
        private string password="Test";
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
                    throw new PasswordIncorrectException();
                }

            }
        }
        public void PasswordChck()
        {
            bool flag2 = false;
            bool flag = false;
            do (flag == false)
            {
                string att = Console.ReadLine();
                flag2 = false;
                try { Password = att; }
                catch (PasswordIncorrectException)
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
        public void Inset(string passent)
        {
            password = passent;
        }

    } 
}
