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
//Console.Write("Digite um número inteiro:");
//int numInteiro = Convert.ToInt32(Console.ReadLine());

//if (numInteiro % 2 == 0 && numInteiro > 0)
//{
//    Console.WriteLine("O seu número é par e positivo");
//}
//else if (numInteiro % 2 != 0 && numInteiro >= 0)
//{
//    Console.WriteLine("O seu número é ímpar e positivo");
//}
//else if (numInteiro < 0)
//{
//    Console.WriteLine("O seu número é negativo");
//}
//else
//{
//    Console.WriteLine("O seu número é Zero");
//}
#endregion

#region 3. Validação de Login Simples
//bool validador = true;
//while(validador)
//{
//    Console.WriteLine("\nTela de Login");
//    Console.Write("Digite o seu Login:");
//    string login = Console.ReadLine();

//    Console.Write("Digite a seu senha:");
//    string senha = Console.ReadLine();

//    if (login == "admin" && senha == "12345")
//    {
//        Console.WriteLine("Login efetuado com sucesso");
//        validador = false;
//    }
//    else
//    {
//        Console.WriteLine("Usuário ou senha inválidos");
//    }
//    Console.ReadKey();
//}
#endregion

//Nível 3: Estruturas de Repetição (Loops)

#region 1. Contagem Regressiva

//for(int i = 10; i != 0; i--)
//{
//    Console.WriteLine($"Tempo restante: {i}");
//    Thread.Sleep( 1000 );
//}
//Console.WriteLine("\nLançar");
//Console.ReadKey();

#endregion

#region 2. Soma de Ímpares (Loop while)
//int acumulador = 0;
//while(true)
//{
//    Console.WriteLine("\n-----Somatório de Número ímpares");
//    Console.Write("Digite um número (Digite 0 para encerrar):");

//    int numeroImpar = Convert.ToInt32(Console.ReadLine());

//    if (numeroImpar % 2 != 0)
//    {
//        acumulador = acumulador + numeroImpar;
//    }
//    else if (numeroImpar == 0)
//    {
//        break;
//    }
//}
//Console.WriteLine($"A somatória de todos os valores ímpares é: {acumulador}");

#endregion

#region 3. Tabuada Personalizada
//Console.WriteLine("\n-----Tabuada de números inteiro------");
//Console.Write("Digite um número inteiro:");
//int numeroTabuada = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i<= 10; i++)
//{
//    int valorTabuada = numeroTabuada * i;

//    Console.WriteLine($"{numeroTabuada} x {i} = {valorTabuada}");
//    Thread.Sleep( 1000 );
//}
//Console.ReadKey();
#endregion

//Nível 4: Coleções(Arrays e Listas)

#region 1. Inversão de Array
//using System.Runtime.InteropServices;

//List<string> nomes = new List<string>();
//Console.WriteLine("\nLista com 5 nomes");
//for (int i = 1; i <= 5; i++)
//{

//    Console.Write($"Digite o {i}º nome:");
//    string nomeDigitado = Console.ReadLine();

//    nomes.Add(nomeDigitado);
//}

//foreach (string nome in nomes)
//{ 
//    Console.WriteLine(nome); 
//}
//Console.ReadKey();
//Console.WriteLine("\n");

//for (int i = nomes.Count - 1; i >=0; i--)
//{
//    Console.WriteLine(nomes[i]);
//}
#endregion

#region 2. Busca e Contagem em Listaa(Foreach)
using System;

//Criando a lista de cores
List<string> cores = new List<string>();

//Adicionando as cores
cores.Add("Azul");
cores.Add("Amarelo");
cores.Add("Verde");
cores.Add("Azul");
cores.Add("Verde");
cores.Add("Azul");
cores.Add("Amarelo");
cores.Add("Vermelho");
cores.Add("Preto");
cores.Add("Amarelo");
cores.Add("Rosa");

Console.Write("Ecolha uma cor para buscar na lista:");
string corEscolhida = Console.ReadLine();
int count = 0;

foreach (string cor in cores)
{
    if (corEscolhida == cor)
    {
        count = count + 1;
    } 
}
if (count > 0)
{
    Console.WriteLine($"A cor que você escolheu se repete {count} vezes");
} 
else
{
    Console.WriteLine($" {count} A cor digitado não foi encontrada");
}


#endregion