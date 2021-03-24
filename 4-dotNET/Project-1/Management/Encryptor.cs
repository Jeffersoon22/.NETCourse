using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Encryptor
{
    private static readonly AesManaged AES = new AesManaged();
    private static byte[] Key = new byte[16] { 1, 3, 4, 3, 5, 6, 7, 8, 9, 4, 3, 2, 4, 5, 6, 7 };
    private static byte[] IV = new byte[16] { 4, 3, 2, 1, 5, 6, 7, 8, 6, 5, 4, 3, 2, 1, 6, 2 };

    public string EncryptString(string plainText)
    {
        byte[] array;
        try
        {
            using (Aes aes = Aes.Create())
            {

                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }
        catch (Exception e)
        {
            string str = e.Message;
            return str;
        }
    }
}