using System;

namespace Ceasor_Cipher
{
    class Ceasor_Func{
        private string deword;
        public string De_Word { get; set; }
        
        private char[] StrToArr(string Word)
        {
            int k=0;
            char[] sout = new char[Word.Length];
            foreach(char chr in Word){
                
                sout[k]=chr;
                k=k+1;
            }
            return sout;
        }
        public string Dcr (char[] De_Word){
            string[] str = new 
            for(int i=0;i<28;i++){
                foreach(char chr in De_Word){
                    De_Word[]
                }
            }

        }
    }


}