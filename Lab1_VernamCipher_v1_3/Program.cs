using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Lab1_VernamCipher_v1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser prsr = new Parser();

            List<String> aStr = prsr.parser();
            keyGeneration myKey = new keyGeneration();
            List<String> lKey = myKey.lKeygen(aStr);
            
            
            List<String> lCipher = new List<string>();
            List<String> lDecText = new List<string>();
           
            Dictionary<String, String> text_key = new Dictionary<String, String>();
            for(int i = 0; i < lKey.Count || i < aStr.Count; i++) //|| i < lKey.Count; i++)
            {
                text_key.Add(aStr[i], lKey[i]);
            }

            //Dictionary<String, String>.KeyCollection keyColl = text_key.Keys;
            foreach (KeyValuePair<String, String> pair in text_key)
            {
                string sCipher = "";
                for (int i = 0; i < pair.Key.Length; i++)
                {
                    sCipher += Convert.ToChar(pair.Key[i] ^ pair.Value[i]); 
                }
                lCipher.Add(sCipher);
            }

            text_key = null;

            Console.WriteLine("-------------------------------------------\nCipher\n");
            foreach (string s in lCipher)
            {
                Console.WriteLine(s);
            }


            using (StreamWriter lChipherWriter = new StreamWriter("I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\cipher.txt"))
            {
                foreach (string s in lCipher)
                {
                    lChipherWriter.WriteLine(s);
                }
            }
            
            Dictionary<String, String> cipher_key = new Dictionary<String,String>();
            for (int i = 0; i < lCipher.Count || i < lKey.Count; i++)
            {
                cipher_key.Add(lCipher[i], lKey[i]);
            }

            foreach (KeyValuePair<String, String> pair in cipher_key)
            {
                string sDecText = "";
                for (int i = 0; i < pair.Key.Length || i < pair.Value.Length; i++)
                {
                    sDecText += Convert.ToChar(pair.Key[i] ^ pair.Value[i]);
                }
                lDecText.Add(sDecText);
            }
            cipher_key = null;

            Console.WriteLine("-------------------------------------------\ndecText\n\n");
            foreach (string s in lDecText)
            {
                Console.WriteLine(s);
            }

            using (StreamWriter lDecTextWriter = new StreamWriter("I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\decText.txt"))
            {
                foreach (string s in lDecText)
                {
                    lDecTextWriter.WriteLine(s);
                }
            }
                
            /*
            for (int i = 0; i < lCipher.Count; i++)
            {
                Console.WriteLine("chiper list:\n" + lCipher[i]);
            }*/


                Console.WriteLine("-------------------------------------------");
            /*
            Console.WriteLine("decText:\n" + decText);
            Console.WriteLine("-------------------------------------------\n\n\n");
            */
                string result = ""; 
            for (int i = 0; i < aStr.Count; i++)
            {
                    
                if (lDecText[i] == aStr[i])
                {
                    result = "Расшифровка шифртекста по известному ключу\nпрошла успешно\n       -------";
                }
                else result = "Расшифровка шифртекста по известному ключу\nпотерпела провал\n          ------";
            }
            Console.WriteLine(result);
                    
                    Console.ReadKey();
            

        }
    }
}
