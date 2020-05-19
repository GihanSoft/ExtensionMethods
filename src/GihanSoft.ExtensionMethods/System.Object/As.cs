namespace GihanSoft {
    public static partial class Extensions {
        public static T As<T> (this object @this)
        where T : class {
            return @this as T;
        }
    }
}