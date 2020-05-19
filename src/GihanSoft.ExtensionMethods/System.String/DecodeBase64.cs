using System;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static byte[] DecodeBase64(this string @this)
        {
            return Convert.FromBase64String(@this);
        }
    }
}
