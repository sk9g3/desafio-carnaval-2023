namespace desafio_02.Exceptions
{
    public class InvalidImcException : Exception
    {
        private const string DEFAULT_MESSAGE = "Invalid parameters";

        public InvalidImcException(string message = DEFAULT_MESSAGE) : base(message) { }

        public static void ThrowIfInvalid(double peso,double altura, string message = DEFAULT_MESSAGE)
        {
            if (peso <= 0)
                throw new InvalidImcException(message);
            if (altura <= 0)
                throw new InvalidImcException(message);
        }
    }
}