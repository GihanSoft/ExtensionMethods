using System;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static string Encode<TEncoding>(this byte[] @this)
            where TEncoding : Encoding
        {
            if (@this.IsNull()) return null;
            var encoding = Activator.CreateInstance<TEncoding>();
            return encoding.GetString(@this);
        }

        public static string Encode(this byte[] @this, Encoding encoding)
        {
            if (@this.IsNull()) return null;
            return encoding.GetString(@this);
        }

        /// <summary>
        /// Default Encoding is UTF8
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Encode(this byte[] @this)
        {
            if (@this.IsNull()) return null;
            return Encoding.UTF8.GetString(@this);
        }
    }
}
