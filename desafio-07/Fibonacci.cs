namespace desafio_07
{
    public static class Fibonacci
    {
        public static string Calcular(int numeroCalcular)
        {
            StringBuilder fibonacci = new StringBuilder();
            StringBuilder sequenciaFibonacci = new StringBuilder();
            var numero1 = 0;
            var numero2 = 1;
            for (int indice = 0; indice < numeroCalcular; indice++)
            {
                sequenciaFibonacci.Append(numero1.ToString().PadLeft(6, ' '));
                var soma = numero1 + numero2;
                numero1 = numero2;
                numero2 = soma;
                fibonacci.AppendLine(sequenciaFibonacci.ToString());
            }
            return fibonacci.ToString();
        }
    }
}