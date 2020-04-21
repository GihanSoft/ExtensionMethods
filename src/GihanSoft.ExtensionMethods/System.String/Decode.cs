using System;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static byte[] Decode<TEncoding>(this string src)
            where TEncoding : Encoding
        {
            if (src.IsNull()) return null;
            var encoding = Activator.CreateInstance<TEncoding>();
            return encoding.GetBytes(src);
        }

        public static byte[] Decode(this string src, Encoding encoding)
        {
            if (src.IsNull()) return null;
            return encoding.GetBytes(src);
        }

        /// <summary>
        /// Default Encoding is UTF8
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static byte[] Decode(this string src)
        {
            if (src.IsNull()) return null;
            return Encoding.UTF8.GetBytes(src);
        }
    }
}
