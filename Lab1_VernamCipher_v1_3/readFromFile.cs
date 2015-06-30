using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1_VernamCipher_v1_2
{
    class readFromFile
    {
        List<String> arrayStr = new List<string>();
        FileStream fTest = File.OpenRead("test.txt");

        public List<String> rFF ()
        {
            for (int i = 0; i < fTest.Length; i++)
            {
                while (fTest.CanRead)
                {
                    // преобразуем строку в байты
                    byte[] array = new byte[fTest.Length];
                    // считываем данные
                    fTest.Read(array, 0, array.Length);
                    // декодируем байты в строку
                    arrayStr[i] = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine("Текст из файла: {0}", arrayStr[i]);
                }
            }

            fTest.Close();
            return arrayStr;
        }
        
    }
}
