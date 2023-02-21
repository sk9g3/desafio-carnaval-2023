namespace desafio_05.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNotNullOrNotEmpty(this string value) => !string.IsNullOrEmpty(value);

        public static void AppendIfNotNull(this StringBuilder stringBuilder, string format, object? arg0, object? arg1)
        {

            if (arg1 == null)
                return;
            if (arg1.GetType() == typeof(string) && string.IsNullOrEmpty(arg1.ToString()))
                return;
            stringBuilder.AppendFormat(format, arg0, arg1);
        }
        public static void AppendIfNotNull(this StringBuilder stringBuilder, string format, object? arg0)
        {

            if (arg0 == null)
                return;
            if (arg0.GetType() == typeof(string) && string.IsNullOrEmpty(arg0.ToString()))
                return;
            stringBuilder.AppendFormat(format, arg0);

        }
    }
}
