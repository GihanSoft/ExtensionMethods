using System.Security.Cryptography;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static byte[] Hash(this string src, HashAlgorithm hashAlgorithm)
        {
            var bytes = Encoding.UTF8.GetBytes(src);
            return hashAlgorithm.ComputeHash(bytes);
        }
    }
}