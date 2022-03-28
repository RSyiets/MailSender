using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MailSender {
    public static class AESCryption
    {
        private const string iv = @"pf69DL6GrWFyZcMK";
        private const string key = @"9Fix4L4HB4PKeKWY";

        /// <summary>
        /// 対称鍵暗号を使って文字列を暗号化する
        /// </summary>
        /// <param name="text">暗号化する文字列</param>
        /// <returns>暗号化された文字列</returns>
        public static string Encrypt(string text)
        {

            using (var rijndael = new RijndaelManaged())
            {
                rijndael.BlockSize = 128;
                rijndael.KeySize = 128;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;

                rijndael.IV = Encoding.UTF8.GetBytes(iv);
                rijndael.Key = Encoding.UTF8.GetBytes(key);

                var encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);

                byte[] encrypted;
                using (var mStream = new MemoryStream())
                using (var ctStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write)) {
                    using (var sw = new StreamWriter(ctStream)) {
                        sw.Write(text);
                    }
                    encrypted = mStream.ToArray();
                }
                return Convert.ToBase64String(encrypted);
            }
        }

        /// <summary>
        /// 対称鍵暗号を使って暗号文を復号する
        /// </summary>
        /// <param name="cipher">暗号化された文字列</param>
        /// <returns>復号された文字列</returns>
        public static string Decrypt(string cipher)
        {
            using (var rijndael = new RijndaelManaged())
            {
                rijndael.BlockSize = 128;
                rijndael.KeySize = 128;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;

                rijndael.IV = Encoding.UTF8.GetBytes(iv);
                rijndael.Key = Encoding.UTF8.GetBytes(key);

                var decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);

                var plain = string.Empty;
                using (var mStream = new MemoryStream(Convert.FromBase64String(cipher)))
                using (var ctStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(ctStream)) {
                    plain = sr.ReadLine();
                }
                return plain;
            }
        }
    }
}
