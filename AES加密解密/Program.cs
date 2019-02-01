using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AES加密解密
{
    public class GetAccountInfoRes
    {
        public string Name { get; set; }
        public Int64 UserID { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var key = "bcd59b53c3103bf1";

            var str = "{\"Name\":\"admin\",\"UserID\":1}";

            string aseStr = AesEncrypt(str, key);
            Console.WriteLine(aseStr);


            var body = "B5KsrsnRYwmjG6bJrnZZ2YH5eIWkWPjl0Puzt0bjaPo=";

            string json = AesDecrypt(body, key);

            Console.WriteLine(json);

            Console.ReadKey();
        }

        /// <summary>
        ///  AES 加密
        /// </summary>
        /// <param name="str">明文（待加密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static string AesEncrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);
            var keyBytes = Encoding.UTF8.GetBytes(key);
            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                IV = keyBytes.Take(16).ToArray()
            };

            ICryptoTransform cTransform = rm.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        /// <summary>
        ///  AES 解密
        /// </summary>
        /// <param name="str">明文（待解密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static string AesDecrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Convert.FromBase64String(str);
            var keyBytes = Encoding.UTF8.GetBytes(key);
            RijndaelManaged rm = new RijndaelManaged
            {
                Key = keyBytes,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                IV = keyBytes.Take(16).ToArray()
            };

            ICryptoTransform cTransform = rm.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }
    }
}
