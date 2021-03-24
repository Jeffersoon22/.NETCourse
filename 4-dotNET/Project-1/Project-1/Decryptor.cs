using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Project_1
{
    
    class Decryptor
    {
        private static byte[] Key = new byte[16] { 1, 3, 4, 3, 5, 6, 7, 8, 9, 4, 3, 2, 4, 5, 6, 7 };
        private static byte[] IV = new byte[16] { 4, 3, 2, 1, 5, 6, 7, 8, 6, 5, 4, 3, 2, 1, 6, 2 };


        public string DecryptString(string inputedText)
        {
            byte[] buffer = Convert.FromBase64String(inputedText);

            using (Aes aes = Aes.Create())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(Key,IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
