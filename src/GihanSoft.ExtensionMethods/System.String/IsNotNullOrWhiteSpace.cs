namespace GihanSoft
{
    public static partial class Extensions
    {
        public static bool IsNotNullOrWhiteSpace(this string @this)
        {
            return !string.IsNullOrWhiteSpace(@this);
        }
    }
}