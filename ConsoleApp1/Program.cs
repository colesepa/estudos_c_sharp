// See https://aka.ms/new-console-template for more information

// Conceitos  básicos de Outputs de dados
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is: " + DateTime.Now);

Console.WriteLine("Congratulations!");
Console.WriteLine(" ");
Console.WriteLine("Eu escrevi minha primeira linha de código!");
Console.Write("Aqui não pula linhas, ");
Console.Write("Viu ?!");

Console.WriteLine("Essa é a primeira linha.");
Console.WriteLine("Essa é a segunda Linha.");
Console.Write(34f);
Console.WriteLine();

/*

Tipos primitivos de dados:

    char (caracter) -> Alfanumérico Literal, deve ser declarado com aspas simples ''. 
        Exemplo: 'b'

    string -> Conjunto de 'char', deve ser declarado com aspas duplas "".
        Exemplo: "Matheus"
    
    int -> Número inteiro.
        Exemplo: 34
    
    float -> Número de ponto fluante ("decimal"), tem uma menor prcisão (6 ~ 7 dígitos), ocuplando menos espaço de memória (32 bits).
        Exemplo: 34f 
    
    double -> Número de ponto flutuante padrão da lingaguem, tem precisão média de (15 ~ 16 dígitos), ocupando 64 bits de memória.
        Exemplo 34.5 
    
    decimal -> Número de ponto flutuante com maior grau de precisão (28 ~29 dígitos), indicado para cálculos financeiros e/ou
    onde arredondaentos são críticos, ao contrário de float e double, o decimal usa a base 10 para sua definição.
        Exemplo 34.5m

    Observações Gerais:
        Não é permitido a mistura de tipos em operações matemáticas.


*/

// Criando Variaveis

//Padrão de criação -> <type> <nomeVar> = <value>;

string firstName = "Matheus";
Console.WriteLine(firstName);

//Variáveis implicitas -> var <nomeVar> = <value> 

var lastName = "Almeida";
Console.WriteLine(lastName);

//Challenge

var name = "Bob";
var menssagemCounter = 3;
var temperature = 34.5;

Console.WriteLine($"Hello, {name} you have {menssagemCounter} mensages, and today`s temperature is {temperature}C°");