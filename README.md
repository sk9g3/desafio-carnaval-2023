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
| [Desafio 1](#-desafio-01--) | desafio-01 |  ``` dotnet run --project desafio-01 ``` |
| [Desafio 2](#-desafio-02-) | desafio-02 | ``` dotnet run --project desafio-02 ``` 
| [Desafio 4](#-desafio-04-) | desafio-04 | ``` dotnet run --project desafio-04 ``` 
| [Desafio 5](#-desafio-05-) | desafio-05 | ``` dotnet run --project desafio-05 ``` 
| [Desafio 6](#-desafio-06-) | desafio-06 | ``` dotnet run --project desafio-06 ```
| [Desafio 7](#-desafio-07-) | desafio-07 | ``` dotnet run --project desafio-07 ```

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

## 🤯 Desafio 07 <br><a name="desafio07"></a>

Escreva um programa que imprime uma pirâmide na tela, apenas com os números da sequência de Fibonacci.


**Resultado esperado**
```sh
1    
1    1    
1    1    2    
1    1    2    3    
1    1    2    3    5    
1    1    2    3    5    8    
1    1    2    3    5    8    13
```