var mensagem = "Informe o valor final da compra: ";
var mensagemErro = "Não é um valor válido. Por favor ";
Console.Write(mensagem);
double valorFinal;
while (!double.TryParse(Console.ReadLine()?.Replace('.', ','), out valorFinal) || valorFinal <= 0)
{
    Console.Write($"{mensagemErro}{mensagem.ToLower()}");
}
mensagem = "Informe o valor pago: ";
Console.Write(mensagem);
double valorPago;
while (!double.TryParse(Console.ReadLine()?.Replace('.', ','), out valorPago) || valorPago <= 0 || valorPago < valorFinal)
{
    Console.Write($"{mensagemErro}{mensagem.ToLower()}");
}

Console.WriteLine(new Troco(valorFinal, valorPago).ToString());