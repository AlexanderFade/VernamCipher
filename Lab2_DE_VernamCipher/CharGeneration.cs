using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab2_DE_VernamCipher
{
    class CharGeneration
    {
        public char chargen()
        {
            char identifier;
            byte[] randomData = new byte[8];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomData);
            }


            int pos = randomData[0] % 255;
            identifier = (char)pos;
            return identifier;
        }
    }
}
