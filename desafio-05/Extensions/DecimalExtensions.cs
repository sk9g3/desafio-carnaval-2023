namespace desafio_05.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToExtenso(this decimal value) => new Numero(value).ToString();
    }
}
