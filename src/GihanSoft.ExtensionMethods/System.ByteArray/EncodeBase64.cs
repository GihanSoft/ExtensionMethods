using System;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static string EncodeBase64(this byte[] @this)
        {
            return Convert.ToBase64String(@this);
        }
    }
}