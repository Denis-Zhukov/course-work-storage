using System;
using System.Security.Cryptography;
using System.Text;
using static CourseworkDenisZhukov.Auxiliary;

namespace CourseworkDenisZhukov {
    public class TripleDES {
        private static string key = "4b0491301b145974d1c0b02309b5dc64";

        public static string Encrypt(string str) {
            byte[] results;
            try {
                byte[] data = UTF8Encoding.UTF8.GetBytes(str);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()) {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 }) {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        results = transform.TransformFinalBlock(data, 0, data.Length);
                    }
                }
            }
            catch (Exception e) {
                Logger("Ошибка шифрования.", "-", e);
                throw new Exception($"Произошла ошибка в шифровании файла."); 
            }
            return Convert.ToBase64String(results);
        }

        public static string Decrypt(string str) {
            byte[] results;
            try {
                byte[] data = Convert.FromBase64String(str);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()) {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 }) {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        results = transform.TransformFinalBlock(data, 0, data.Length);
                    }
                }
            }
            catch (Exception e) {
                Logger("Ошибка дешифрования.", "-", e);
                throw new Exception($"Произошла ошибка в дешифрования файла."); 
            }
            return UTF8Encoding.UTF8.GetString(results);
        }

    }
}
