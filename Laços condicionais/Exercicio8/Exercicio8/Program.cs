// See https://aka.ms/new-console-template for more information

int idade;

Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());

switch(idade)
{
    case int n when (n >= 0 && n <= 12):
        Console.WriteLine("Criança");
        break;

    case int n when (n >= 13 && n <= 19):
        Console.WriteLine("Adolescente");
        break;

    case int n when (n >= 20 && n <= 59):
        Console.WriteLine("Adulto");
        break;
    case int n when (n >= 60):
        Console.WriteLine("Idoso");
        break;
}
