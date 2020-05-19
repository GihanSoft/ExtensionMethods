using System;

namespace GihanSoft
{
    public partial class Extensions
    {
        public static int Compare(this string @this, string that, StringComparison comparison)
        {
            return string.Compare(@this, that, comparison);
        }
    }
}