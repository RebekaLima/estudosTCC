// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

string nome;
int idade;
bool doador;
bool naoDoador;

Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());


Console.WriteLine("Primeira doação de sangue? *Digite 'sim' ou 'nao'*");
string resposta = Console.ReadLine().ToLower();

naoDoador = resposta == "sim";
doador = resposta == "não";

if (idade >= 18 && idade <= 59 )
{
    Console.WriteLine(nome + " está apto a doar sangue!");
} if (idade >= 60 && idade <= 69 && naoDoador)
{
    Console.WriteLine(nome + " não está apto a doar sangue!");
}
if (idade >= 60 && idade <= 69 && doador)
{
    Console.WriteLine(nome + " está apto a doar");
}
if (idade <= 17)
{
    Console.WriteLine(nome + " não está apto a doar sangue!");
} if (idade >= 70)
{
    Console.WriteLine(nome + " não está apto a doar sangue!");
}

