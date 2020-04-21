using System;
using System.Collections.Generic;
using System.Text;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static bool IsNull<TObject>(this TObject obj)
            where TObject : class
        {
            return obj == null;
        }

        public static bool IsNull<TObject>(this TObject? obj)
            where TObject : struct
        {
            return obj == null;
        }

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
