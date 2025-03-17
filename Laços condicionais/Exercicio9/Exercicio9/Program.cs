// See https://aka.ms/new-console-template for more information
string nota;

Console.WriteLine("Dentre as notas abaixo: ");

Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");
Console.WriteLine("D");
Console.WriteLine("F");

Console.WriteLine("Qual foi a sua?");

nota = Console.ReadLine().ToUpper();

switch (nota)
{
    case "A":
        Console.WriteLine("Excelente");
        break;
    case "B":
        Console.WriteLine("Bom");
        break;
    case "C":
        Console.WriteLine("Médio");
        break;
    case "D":
        Console.WriteLine("Ruim");
        break;
    case "F":
        Console.WriteLine("Insuficiente");
        break;
    default:
        Console.WriteLine("Entrada inválida!");
        break;
}
