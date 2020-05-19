using System.Security.Cryptography;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static byte[] Hash(this string @this, HashAlgorithm hashAlgorithm)
        {
            var bytes = Encoding.UTF8.GetBytes(@this);
            return hashAlgorithm.ComputeHash(bytes);
        }
    }
}