namespace GihanSoft
{
    public static partial class Extensions
    {
        public static bool IsNotNull<TObject>(this TObject @this)
            where TObject : class
        {
            return @this != null;
        }

        public static bool IsNotNull<TObject>(this TObject? @this)
            where TObject : struct
        {
            return @this != null;
        }

        public static bool IsNotNull(this object @this)
        {
            return @this != null;
        }
    }
}
