using System.IO;

namespace GihanSoft
{
    public static partial class Extensions
    {
        public static DirectoryInfo ToDirectoryInfo(this string @this)
        {
            return new DirectoryInfo(@this);
        }
    }
}
