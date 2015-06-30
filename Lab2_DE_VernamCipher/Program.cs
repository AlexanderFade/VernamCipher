using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab2_DE_VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            getTextFromFile gtff = new getTextFromFile();
            KeyGeneration myKey = new KeyGeneration();
            //string dirCipher = "D:\\Users\\AlexFade\\Documents\\Visual Studio 2013\\Projects\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\\\ProgramFiles\\cipher.txt";
            //string dirText = "D:\\Users\\AlexFade\\Documents\\Visual Studio 2013\\Projects\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\\\ProgramFiles\\text.txt";
            
            string dirCipher = "I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\\\ProgramFiles\\cipher.txt";
            string dirText = "I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\\\ProgramFiles\\text.txt";

            string[] cipher;
            string[] orText;
            //string[] deText;
            List<String> lKey = new List<string>();
            Dictionary<String, String> cipher_key = new Dictionary<string,string>();
            Console.WriteLine("Intercepted cipher:\n");
            cipher = gtff.mGetTextFromFile(dirCipher);
            orText = gtff.mGetTextFromFile(dirText);
            
            int countOfTry = 0;
            /*string sKey = myKey.keygen(cipher[0]);
            if (sKey.Length == cipher[0].Length) Console.WriteLine(true);
            else Console.WriteLine(false);
            sKey = "";
            sKey += myKey.keygen(cipher[0]);
            if (sKey.Length == cipher[0].Length) Console.WriteLine(true);
            else Console.WriteLine(false);
            */
            while (true)
            {
                countOfTry++;
                lKey.Add(myKey.keygen(cipher[0]));
                string sDecText = "";
                for (int i = 0; i < lKey[0].Length; i++)
                {
                    sDecText += Convert.ToChar(cipher[0][i] ^ lKey[0][i]);
                }

                    if (sDecText.Equals(orText[0]))
                    {
                        Console.WriteLine("------------------------\n----------Конец----------\n------------------------");
                        Console.WriteLine("Расшифровка завершена успешно");
                        Console.WriteLine("                      -------");
                        Console.WriteLine("Ключ\n" + lKey[0]);
                        Console.WriteLine("------------------------\n----------Teкст---------\n------------------------");
                        Console.WriteLine(sDecText);
                        Console.WriteLine("Попытка № {0}", countOfTry);
                        break;
                    }

                lKey.Remove(lKey[0]);
                //Console.WriteLine("Попытка расшифровать ключ к первой строке | " + countOfTry);
            }
             

                /*
                Console.WriteLine("Key:\n");
                key = gtff.mGetTextFromFile(dirKey);
                Dictionary<String, String> cipher_key = new Dictionary<string, string>();
                for (int i = 0; i < key.Length; i++)
                {
                    cipher_key.Add(cipher[i], key[i]);
                }
                List<String> lDecText = new List<string>();
                //Console.WriteLine(cipher_key.Keys.Count + " / " + cipher_key.Values.Count);
                foreach (KeyValuePair<String, String> pair in cipher_key)
                {
                    string sDecText = "";
                    Console.WriteLine(pair.Key.Length + " / " + pair.Value.Length);
                
                        //sDecText += Convert.ToChar(pair.Key ^ pair.Value);
                
                    //lDecText.Add(sDecText);
                }
                */

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine(elapsedTime, "RunTime");
            Console.ReadKey();
        }
    }
}
