/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DE_VernamCipher
{
    class KeygenChar
    {
        public char KeygenForChar(){
            CharGeneration cg = new CharGeneration();
            char ch;
            ch = cg.chargen();
            return ch;
        }
        public static void Main(String[] args){
            getTextFromFile gtff = new getTextFromFile();
            KeyGeneration myKey = new KeyGeneration();
            KeygenChar myKeyForChar = new KeygenChar();
            
            string dirCipher = "I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\cipher.txt";
            string dirText = "I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\text.txt";

            string[] cipher;
            string[] orText;
            string[] deText;
            List<String> lKey = new List<string>();
            Dictionary<String, String> cipher_key = new Dictionary<string, string>();
            Console.WriteLine("Intercepted cipher:");
            cipher = gtff.mGetTextFromFile(dirCipher);
            Console.WriteLine("Original text:");
            orText = gtff.mGetTextFromFile(dirText);
            int countOfTry = 0;
            
            string decText = "";
            while (true)
            {
                char ch = ' ';
                countOfTry++;

                for (int i = 0; i < cipher[0].Length; i++)
                {
                    ch = myKeyForChar.KeygenForChar();
                    if (ch == orText[0][i])
                    {
                        decText += ch;
                        Console.WriteLine("success | " + ch);
                    }
                    else if (i == cipher[0].Length) break;
                    else continue;
                    Console.WriteLine("finish first is");
                    if (decText == orText[0])
                    {
                        Console.WriteLine("Decoding text is:\n--------------------------\n");
                        Console.WriteLine(decText);
                        break;
                    }
                }
            }
            Console.WriteLine(countOfTry);
            Console.ReadKey();
        }
    }
}
*/