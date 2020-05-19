using System.IO;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static FileInfo ToFileInfo(this string @this)
        {
            return new FileInfo(@this);
        }
    }
}
