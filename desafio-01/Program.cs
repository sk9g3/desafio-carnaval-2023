Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine()!;

var (caracteres, palavras) = Caracter.ObterQuantidadeCaracteresEPalavras(texto);

Console.WriteLine($"{caracteres} caracteres, {palavras} palavras");