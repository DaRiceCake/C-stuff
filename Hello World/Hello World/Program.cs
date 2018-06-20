using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Properties
    {
        public int trackerbar = 0;
        private string tester;
        public string Tester
        {
            get {
                trackerbar = trackerbar + 1;
                return tester; }

            set { tester = value; }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}
