var valorMaximo = 2147483647;
decimal valorFinal;
var mensagem = "Informe o valor final da compra: ";
Console.Write(mensagem);
while (!decimal.TryParse(Console.ReadLine()?.Replace('.', ','), out valorFinal) || valorFinal > valorMaximo)
{
    Console.Write($"Não é um valor válido. Por favor {mensagem.ToLower()}");
}

Console.WriteLine($"{valorFinal.ToExtenso()}");

