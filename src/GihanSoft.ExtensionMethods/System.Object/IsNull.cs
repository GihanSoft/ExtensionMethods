namespace GihanSoft
{
    public static partial class Extensions
    {
        public static bool IsNull<TObject>(this TObject @this)
            where TObject : class
        {
            return @this == null;
        }

        public static bool IsNull<TObject>(this TObject? @this)
            where TObject : struct
        {
            return @this == null;
        }

        public static bool IsNull(this object @this)
        {
            return @this == null;
        }
    }
}
