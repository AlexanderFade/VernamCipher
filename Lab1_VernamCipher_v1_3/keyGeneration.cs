using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1_VernamCipher_v1_2
{
    class keyGeneration
    {
        public string keygen(string text)
        {
            string strKey = "";
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++ )
            {
                strKey += (char)rnd.Next(0,255);
                File.WriteAllText("I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\key.txt", strKey);
            }
            Console.WriteLine("key:\n" + strKey);
                return strKey;
        }

        public List<String> lKeygen(List<String> text)
        {
            
            Random rnd = new Random();
            List<String> lKey = new List<string>();
            //text.ForEach(foreach(char c in ))
            foreach (String s in text)
            {
                string sKey = "";
                foreach(char c in s)
                {
                    sKey += (char)rnd.Next(0, 255);
                }
                lKey.Add(sKey);
                
            }
            
            Console.WriteLine("Keys for every string in original text :\n");
            
            foreach (string s in lKey)
            {
                    Console.WriteLine(s);
            }
            /*StreamWriter lKeyWriter = new StreamWriter(@"C:\Users\ADMIN\Documents\Visual Studio 2013\Projects\Lab1_VernamCipher\Lab1_VernamCipher_v1_2\ProgramFiles\key.txt");
            foreach (string s in lKey)
            {
                lKeyWriter.WriteLine(s);
            }*/
            //------------------------
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\key.txt"))
            {
                foreach (string line in lKey)
                {
                    file.WriteLine(line);
                }
            }
            //------------------------


                return lKey;
        }
    }
}
