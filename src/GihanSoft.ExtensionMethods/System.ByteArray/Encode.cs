using System;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static string Encode<TEncoding>(this byte[] src)
            where TEncoding : Encoding
        {
            if (src.IsNull()) return null;
            var encoding = Activator.CreateInstance<TEncoding>();
            return encoding.GetString(src);
        }

        public static string Encode(this byte[] src, Encoding encoding)
        {
            if (src.IsNull()) return null;
            return encoding.GetString(src);
        }

        /// <summary>
        /// Default Encoding is UTF8
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static string Encode(this byte[] src)
        {
            if (src.IsNull()) return null;
            return Encoding.UTF8.GetString(src);
        }
    }
}
