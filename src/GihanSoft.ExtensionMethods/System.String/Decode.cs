using System;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static byte[] Decode<TEncoding>(this string @this)
            where TEncoding : Encoding
        {
            if (@this.IsNull()) return null;
            var encoding = Activator.CreateInstance<TEncoding>();
            return encoding.GetBytes(@this);
        }

        public static byte[] Decode(this string @this, Encoding encoding)
        {
            if (@this.IsNull()) return null;
            return encoding.GetBytes(@this);
        }

        /// <summary>
        /// Default Encoding is UTF8
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static byte[] Decode(this string @this)
        {
            if (@this.IsNull()) return null;
            return Encoding.UTF8.GetBytes(@this);
        }
    }
}
