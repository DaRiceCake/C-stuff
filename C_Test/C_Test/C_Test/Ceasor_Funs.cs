using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace C_Test
{
    class Ceasor_Funs
    {
        private char[] StrToArr(string Word)
        {
            int k = 0;
            char[] sout = new char[Word.Length];
            foreach (char chr in Word)
            {

                sout[k] = chr;
                k = k + 1;
            }
            return sout;
        }
        public void Dcr(string Word)
        {

            char[] De_Word = new char[Word.Length];
            string currentchr = "";
            De_Word = StrToArr(Word);
            int[] castchr = new int[De_Word.Length];
            for (int i = 0; i < 28; i++)
            {
                currentchr = "";
                for (int k = 0; k < De_Word.Length; k++)
                {
                    int tempint = De_Word[k] - i;
                    currentchr += (char)tempint;
                }
                Console.WriteLine("Shift = {0} Word = {1}",i,currentchr);
            }
        }
        public void Enc(string Word,int Shift)
        {
            char[] Ec_Word = new char[Word.Length];
            string curchr = "";
            Ec_Word = StrToArr(Word);
            for (int i = 0; i<Ec_Word.Length;i++)
            {
                int tempint = Ec_Word[i]+Shift;
                curchr += (char)tempint;
            }
            Console.WriteLine("Encrypted with shift {0} cipher text = {1}",Shift,curchr);
        }

    }


}
    

