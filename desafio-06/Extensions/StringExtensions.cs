namespace desafio_06.Extensions
{
    public static class StringExtensions
    {
        static Dictionary<string, string> letras = new Dictionary<string, string>()
        {
            {"a", "K"},{"b", "M"},{"c", "Z"},{"d", "A"},{"e", "L"},
            {"f", "N"},{"g", "O"},{"h", "I"},{"i", "P"},{"j", "Y"},
            {"k", "E"},{"l", "F"},{"m", "Q"},{"n", "J"},{"o", "W"},
            {"p", "R"},{"q", "X"},{"r", "T"},{"s", "V"},{"t", "B"},
            {"u", "C"},{"v", "S"},{"w", "H"},{"x", "D"},{"y", "G"},
            {"z", "U"}
        };
        
        public static string Encrypt(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;
            
            value = value.ToLower();

            var letrasRegex = string.Join(",", letras.Keys);
            return Regex.Replace(value, $@"([{letrasRegex}])", delegate (Match match)
            {
                return letras[match.Value];
            });
        }
        public static string Decrypt(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            var letrasRegex = string.Join(",", letras.Values);
            return Regex.Replace(value, $@"([{letrasRegex}])", delegate (Match match)
            {
                return letras.FirstOrDefault(letra => letra.Value == match.Value).Key;
            });
        }
        
    }
}