// See https://aka.ms/new-console-template for more information
int idade;

Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade :)");
} else if (idade >= 1)
{
    Console.WriteLine("Você é menor de idade :(");
} else
{
    Console.WriteLine("Idade inválida!");
}
