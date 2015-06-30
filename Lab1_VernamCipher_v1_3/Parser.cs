using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1_VernamCipher_v1_2
{
    class Parser
    {
        List<String> text = new List<string>();

        public List<String> parser()
        {
            //int counter = 0;
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("I:\\Lab1_VernamCipher\\Lab1_VernamCipher_v1_3\\ProgramFiles\\text.txt");
            Console.WriteLine("text:\n-------------------------------------------");
            while ((line = file.ReadLine()) != null)
            {
                text.Add(line);
                //System.Console.WriteLine(line);                
                //counter++;
            }
            //int counter = 0;
            foreach (String s in text)
            {
                Console.WriteLine(s);
                //counter++;
            }
            Console.WriteLine("-------------------------------------------");
            file.Close();
            // Suspend the screen.

            //System.Console.ReadLine();
            return text;
        }
        
    }
}
