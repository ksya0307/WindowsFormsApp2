using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class ToAes256
    {
        
        //public  byte[] Encrypt_pwd(string pwd)
        //{
        //    //объявляем объект класса AES
        //    Aes aes = Aes.Create();
        //    //герерируем соль
        //    aes.GenerateIV();
        //    aes.GenerateKey();
        //    byte[] encrypted;
        //    ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        using (CryptoStream cs = new CryptoStream(ms, crypto, CryptoStreamMode.Write))
        //        {
        //            using(StreamWriter sw = new StreamWriter(cs))
        //            {
        //                sw.Write(pwd);
        //            }
        //        }
        //        encrypted = ms.ToArray();
        //    }
            
        //    return encrypted.Concat(aes.IV).ToArray();
        //}
        //public  string Decrypt_pwd(byte[] shifr)
        //{
        //    byte[] bytesIv = new byte[16];
        //    byte[] mess = new byte[shifr.Length - 16];

        //    for(int i = shifr.Length - 16, j = 0; i < shifr.Length; i++, j++)
        //    {
        //        bytesIv[j] = shifr[i];
        //    }
        //    for (int i = 0; i < shifr.Length - 16; i++) mess[i] = shifr[i];

        //    Aes aes = Aes.Create();
        //    aes.IV = bytesIv;
        //    aes.GenerateKey();
        //    string text = "";
        //    byte[] data = mess;
        //    ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        using (CryptoStream cs = new CryptoStream(ms, crypto, CryptoStreamMode.Read))
        //        {
        //            using (StreamReader sr = new StreamReader(cs))
        //            {
        //                text = sr.ReadToEnd();
        //            }
        //        }
        //    }

        //    return text;
        //}
        public  void enc()
        {
            byte[] salt = new byte[] { 172, 137, 25, 56, 156, 100, 136, 211, 84, 67, 96, 10, 24, 111, 112, 137, 3 };
            int iterations = 1024;
            var rfc2898 =
            new System.Security.Cryptography.Rfc2898DeriveBytes("0123456789ABCDEF", salt, iterations);
            byte[] key = rfc2898.GetBytes(16);
            String keyB64 = Convert.ToBase64String(key);
            System.Console.WriteLine("Key: " + keyB64);
            AesManaged aesCipher = new AesManaged();
            aesCipher.KeySize = 128;
            aesCipher.BlockSize = 128;
            aesCipher.Mode = CipherMode.CBC;
            aesCipher.Padding = PaddingMode.PKCS7;
            string cleartext = "P@ssw0rd";
            aesCipher.Key = key;
            byte[] b = System.Text.Encoding.UTF8.GetBytes(cleartext);
            ICryptoTransform encryptTransform = aesCipher.CreateEncryptor();
            byte[] ctext = encryptTransform.TransformFinalBlock(b, 0, b.Length);
            System.Console.WriteLine("IV:" + Convert.ToBase64String(aesCipher.IV));
            System.Console.WriteLine("Cipher text: " + Convert.ToBase64String(ctext));
        }
    }

}
