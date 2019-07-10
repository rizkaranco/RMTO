using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace HPS.Common
{
    class EncryptUserPass
    {
        public byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {

             byte[] rawPlaintext = System.Text.Encoding.Unicode.GetBytes(plainText);
            string s = string.Empty;
            using (Aes aes = new AesManaged())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 128;          // in bits
                aes.Key = new byte[128 / 8];  // 16 bytes for 128 bit encryption
                aes.IV = new byte[128 / 8];   // AES needs a 16-byte IV
                // Should set Key and IV here.  Good approach: derive them from 
                // a password via Cryptography.Rfc2898DeriveBytes 
                byte[] cipherText = null;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(rawPlaintext, 0, rawPlaintext.Length);
                    }

                    cipherText = ms.ToArray();
                }
                return cipherText;
            }

        }

        public string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold // the decrypted text. 
            string plaintext = null;

            // Create an Rijndael object // with the specified key and IV. 
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        { 
                            // Read the decrypted bytes from the decrypting stream // and place them in a string.
                             plaintext =srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }


        public string DecryptUserPassword(byte[] cipherText)
        {
           // byte[] rawPlaintext = System.Text.Encoding.Unicode.GetBytes(cipherText);
            string decreptedText = string.Empty;
            using (Aes aes = new AesManaged())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 128;          // in bits
                aes.Key = new byte[128 / 8];  // 16 bytes for 128 bit encryption
                aes.IV = new byte[128 / 8];   // AES needs a 16-byte IV
                // Should set Key and IV here.  Good approach: derive them from 
                byte[] plainText = null;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherText, 0, cipherText.Length);
                    }

                    plainText = ms.ToArray();
                }
                decreptedText = System.Text.Encoding.Unicode.GetString(plainText);
               
            }
            return decreptedText;
        }
    }
}
