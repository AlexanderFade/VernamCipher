using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab2_DE_VernamCipher
{
    class KeyGeneration
    {
        public string keygen(string text)
        {
            string strKey = "";
            
            //Random rnd = new Random();
            CharGeneration cg = new CharGeneration();
            for (int i = 0; i < text.Length; i++)
            {
                strKey += cg.chargen();
                //File.WriteAllText(@"D:\Users\AlexFade\Documents\Visual Studio 2013\Projects\Lab1_VernamCipher\key.txt", strKey);
            }


            //Console.WriteLine("key:\n" + strKey);
            return strKey;
        }
    }
}
