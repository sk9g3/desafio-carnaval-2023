# Desafio de Carnaval
> Desafios feito por André Baltieri no grupo do discord

## 💻 Pré-requisitos

Antes de começar, verifique se  instalou a versão mais recente do <a href="https://dotnet.microsoft.com/download">SDK do .NET</a>.


<br/>

## 🚀 Executando o projeto
Faça o download do código executando o seguinte comando:
```git
git clone https://github.com/sk9g3/desafio-carnaval-2023.git
```
Navegue até a diretório do projeto e execute o seguinte comando:
```
dotnet run --project <NOME_PROJETO>
```

| PROJETO   |  NOME_PROJETO  |   COMANDO      |
|----------------|:-------------:|:-------------:|
| <a href="desafio01">Desafio 1</a> | desafio-01 |  ``` dotnet run --project desafio-01 ``` |
| <a href="desafio02">Desafio 2</a> | desafio-02 | ``` dotnet run --project desafio-02 ``` 
| <a href="desafio04">Desafio 4</a> | desafio-04 | ``` dotnet run --project desafio-04 ``` 
| <a href="desafio05">Desafio 5</a> | desafio-05 | ``` dotnet run --project desafio-05 ``` 
| <a href="desafio06">Desafio 6</a> | desafio-06 | ``` dotnet run --project desafio-06 ```
<br/>
<br/>

## 🤯 Desafio 01 <br> <a name="desafio01"></a>

Escreva um programa que conte a quantidade de palavras e caracteres que um determinado texto, escrito no Console, contém.

**Resultado esperado**
```sh
Digite um texto:
 Este texto foi digitado no console
34 caracteres, 6 palavras
```

## 🤯 Desafio 02 <br> <a name="desafio02"></a>

Escreva um programa que calcula o IMC (Índice de massa corporal de uma pessoa) e exibe o resultado.

**Resultado esperado**
```sh
Informe sua altura: 1,75
Informe seu peso: 85

> Seu IMC é 27.76
> Sobrepeso
> Obesidade Grau I
> Risco: Aumentado
```

## 🤯 Desafio 04 <br> <a name="desafio04"></a>

Escreva um programa que informa o troco a ser recebido pelo cliente, por exemplo:

**Resultado esperado**
```sh
- Valor final da compra: R$ 328,00
- Pagamento: R$ 400,00
- Troco:
    - 1 nota de 2 reais
    - 2 notas de 10 reais
    - 2 notas de 50 reais
```

## 🤯 Desafio 05 <br><a name="desafio05"></a>

Escreva um programa que informa o valor por extenso, por exemplo:

**Resultado esperado**
```sh
- Valor final da compra: 328,90
- Output do programa: TREZENTOS E VINTE E OITO REAIS E NOVENTA CENTAVOS
```

## 🤯 Desafio 06 <br><a name="desafio06"></a>

Escreva um programa que encripta um texto utilizando uma tabela de mapeamento de caracteres, por exemplo:

a = K, n = J, d = A, r = T, e = L

**Resultado esperado**
```sh
Input: andre
Output: KJATL
```