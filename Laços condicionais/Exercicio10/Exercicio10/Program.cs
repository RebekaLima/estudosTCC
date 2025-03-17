// See https://aka.ms/new-console-template for more information
int leitura;

Console.WriteLine("Digite o número referente a lista de sugestões que você deseja: ");
Console.WriteLine("                                                                ");
Console.WriteLine("****************************************************************");
Console.WriteLine("                     1 - Jane Austen                            ");
Console.WriteLine("                     2 - Jorge Amado                            ");
Console.WriteLine("                     3 - Fiódor Dostoiévski                     ");
Console.WriteLine("****************************************************************");
Console.WriteLine("                                                                ");

leitura = int.Parse(Console.ReadLine());

switch (leitura)
{
    case 1:
        Console.WriteLine("Emma");
        Console.WriteLine("Persuasão");
        Console.WriteLine("Orgulho de preconceito");
        break;
    case 2:
        Console.WriteLine("Capitães da areia");
        Console.WriteLine("Gabriela cravo e canela");
        Console.WriteLine("Dona flor e seus dois maridos");
        break;
    case 3:
        Console.WriteLine("Crime e castigo");
        Console.WriteLine("Noites brancas");
        Console.WriteLine("O idiota");
        break;
    default:
        Console.WriteLine("Entrada inválida!");
        break;
}
