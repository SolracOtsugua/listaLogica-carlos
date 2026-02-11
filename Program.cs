// See https://aka.ms/new-console-template for more information

//Lista de Exercício lógica c#
//Nível 1: Variáveis e Operações Básicas

#region 1. Calculadora de Média Simples 

Console.Write("Digite sua primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite sua segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite sua terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite sua quarta nota: ");
double nota4 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3 + nota4)/4;

Console.Write("A sua Média é:");
Console.Write(media);
Console.ReadKey();


#endregion
