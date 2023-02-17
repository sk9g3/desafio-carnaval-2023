namespace desafio_01
{
    public static partial class Caracter
    {
        const int ValorPadrao = 0;
        
        public static (int caracteres, int palavras) ObterQuantidadeCaracteresEPalavras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return (ValorPadrao, ValorPadrao);

            texto = texto.Trim();
            return (texto.Length, EspacoBrancoRegex().Split(texto).Length);
        }

        [GeneratedRegex("\\s+")]
        private static partial Regex EspacoBrancoRegex();
    }
}