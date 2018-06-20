using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceasor_Cipher
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
            char[] Outchr = new char[Word.Length];
            char[] De_Word = new char[Word.Length];
            De_Word = StrToArr(Word);
            int[] castchr = new int[De_Word.Length];
            for (int i = 0; i < 28; i++)
            {
                for (int k = 0; k < De_Word.Length; k++)
                {
                    int tempint = De_Word[k] - i;
                    Outchr[k] = (char)tempint;
                }
                Console.WriteLine(Outchr);
            }


        }
    }
}
    

