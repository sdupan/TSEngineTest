using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace UnityTSGame
{
    public class AESUtil
    {
        protected static string aesHead = "__ZCGAME__";

        public static byte[] Encrypt(byte[] plainText, byte[] key)
        {
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = key,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(plainText, 0, plainText.Length);
            byte[] head = Encoding.UTF8.GetBytes(aesHead);
            byte[] encryptArray = new byte[head.Length + resultArray.Length];
            head.CopyTo(encryptArray, 0);
            resultArray.CopyTo(encryptArray, head.Length);
            return encryptArray;
        }

        public static byte[] Decrypt(byte[] cipherText, byte[] key)
        {
            byte[] head = Encoding.UTF8.GetBytes(aesHead);
            if (cipherText.Length <= head.Length)
            {
                return cipherText;
            }

            var same = true;
            byte[] readHead = cipherText.Take(head.Length).ToArray();
            for (int i = 0; i < head.Length; i++)
            {
                if (head[i] != readHead[i])
                {
                    same = false;
                    break;
                }
            }

            if (!same)
            {
                return cipherText;
            }

            byte[] decData = cipherText.Skip(head.Length).Take(cipherText.Length - head.Length).ToArray();
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = key,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(decData, 0, decData.Length);
            return resultArray;
        }

        public static byte[] EncryptText(string plainText, byte[] key)
        {
            return Encrypt(Encoding.UTF8.GetBytes(plainText), key);
        }
    }
}