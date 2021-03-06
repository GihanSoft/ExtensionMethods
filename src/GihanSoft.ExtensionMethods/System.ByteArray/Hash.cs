using System.Security.Cryptography;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static byte[] Hash(this byte[] @this, HashAlgorithm hashAlgorithm)
        {
            return hashAlgorithm.ComputeHash(@this);
        }
    }
}