try
{
    Console.WriteLine("Informe um número para calcular: ");
    int numeroCalcular = int.Parse(Console.ReadLine()!);
    Console.WriteLine(Fibonacci.Calcular(numeroCalcular));
}
catch
{
    Console.WriteLine("Não é um número válido.");
}

