var mensagem = "Informe sua altura em metros: (Ex: 1,80) ";
var mensagemErro = "Não é um valor válido. Por favor ";
Console.Write(mensagem);
double altura;
while (!double.TryParse(Console.ReadLine()?.Replace('.', ','), out altura) || altura <= 0)
{
    Console.Write($"{mensagemErro}{mensagem.ToLower()}");
}

mensagem = "Informe seu peso em quilogramas: (Ex: 73) ";
Console.Write(mensagem);
double peso;
while (!double.TryParse(Console.ReadLine()?.Replace('.', ','), out peso) || peso <= 0)
{
    Console.Write($"{mensagemErro}{mensagem.ToLower()}");
}
Console.WriteLine(new Imc(peso, altura).ToString());
