using System.Security.Cryptography;
using System.Text;

namespace UnityTSGame
{
    public class UTGUtils
    {
        public static bool ObjectIsNull(UnityEngine.Object obj)
        {
            return obj is null;
        }

        public static long BitAnd(long num1, long num2)
        {
            return num1 & num2;
        }

        public static long BitOr(long num1, long num2)
        {
            return num1 | num2;
        }

        public static long BitNot(long num)
        {
            return ~num;
        }

        public static long BitXor(long num1, long num2)
        {
            return num1 ^ num2;
        }

        public static long BitShL(long num, int count)
        {
            return num << count;
        }

        public static long BitShR(long num, int count)
        {
            return num >> count;
        }

        public static string GetMD5(string source)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] newBuffer = mi.ComputeHash(Encoding.UTF8.GetBytes(source));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}