namespace GihanSoft
{
    public static partial class Extensions
    {
        public static T Cast<T>(this object @this)
        {
            return (T)@this;
        }
    }
}
