// See https://aka.ms/new-console-template for more information

//Nível 1: Variáveis e Operações Básicas

#region 1. Calculadora de Média Simples 

//Console.Write("Digite sua primeira nota: ");
//double nota1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite sua segunda nota: ");
//double nota2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite sua terceira nota: ");
//double nota3 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite sua quarta nota: ");
//double nota4 = Convert.ToDouble(Console.ReadLine());

//double media = (nota1 + nota2 + nota3 + nota4)/4;

//Console.WriteLine($"A média das notas é: {media:F2}");
//Console.Write("A sua Média é:");
//Console.Write(media);
//Console.ReadKey();


#endregion

#region 2. Conversor de Idade
//Console.Write("Digite a sua idade em anos: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//int converterDias = idade * 365;

//Console.Write("A sua idade em dias é:");
//Console.WriteLine(converterDias);
//Console.ReadKey();

#endregion

#region 3. Troca de Valores

//int variavelA = 20;
//int variavelB = 40;
//int variavelC = 0;

//Console.WriteLine($"A primeira variável é: {variavelA}, a segunda variável é: {variavelB}");

//variavelC = variavelA;

//variavelA = variavelB;

//variavelB = variavelC;
//Console.WriteLine("--------------------------------------");
//Console.WriteLine($"O novo valor da primeira variável é: {variavelA}, o novo valor da segunda veriável é: {variavelB}");

#endregion

//Nível 2: Estruturas Condicionais(if, else if, else)

#region 1. Verificador de Maioridade
//int Maioridade = 18;

//Console.Write("Digite sua idade:");
//int idadeUsuario = Convert.ToInt32(Console.ReadLine());

//if (idadeUsuario >= Maioridade)
//{
//    Console.WriteLine("Entrada autorizada");
//} 
//else
//{
//    Console.WriteLine("Entrada não autorizada. Menor de idade");
//}
#endregion

#region 2. Classificador de Número
Console.Write("Digite um número inteiro:");
int numInteiro = Convert.ToInt32(Console.ReadLine());

if (numInteiro % 2 == 0 && numInteiro > 0)
{
    Console.WriteLine("O seu número é par e positivo");
}
else if (numInteiro % 2 != 0 && numInteiro >= 0)
{
    Console.WriteLine("O seu número é ímpar e positivo");
}
else if (numInteiro < 0)
{
    Console.WriteLine("O seu número é negativo");
}
else
{
    Console.WriteLine("O seu número é Zero");
}
#endregion
