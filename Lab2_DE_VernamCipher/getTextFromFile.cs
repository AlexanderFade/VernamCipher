using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_DE_VernamCipher
{
    class getTextFromFile
    {
        public string[] mGetTextFromFile(string directory){
            string[] text;
            text = File.ReadAllLines(directory);
            Console.WriteLine("--------------------------\n");
            foreach (string s in text)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n--------------------------\n");
            return text;
        }
    }
}
