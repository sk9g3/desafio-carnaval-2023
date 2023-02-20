namespace desafio_04.Exceptions
{
    public class InvalidTrocoException : Exception
    {
        private const string DEFAULT_MESSAGE = "Valores inválidos";

        public InvalidTrocoException(string message = DEFAULT_MESSAGE) : base(message) { }

        public static void ThrowIfInvalid(double valorFinal, double valorPago, string message = DEFAULT_MESSAGE)
        {
            if (valorFinal <= 0)
                throw new InvalidTrocoException(message);
            if (valorPago <= 0)
                throw new InvalidTrocoException(message);

            if (valorPago < valorFinal)
                throw new InvalidTrocoException("O valor pago não pode ser menor que o valor do Produto");
        }
    }
}