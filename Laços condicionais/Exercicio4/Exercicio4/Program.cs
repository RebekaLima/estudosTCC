// See https://aka.ms/new-console-template for more information
int num;

Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());

if (num%2 == 0)
{
    Console.WriteLine("O número é par");
} if (num >= 0)
{
    Console.WriteLine("e positivo");
} if (num%2 != 0)
{
    Console.WriteLine("O número é impar");
} if (num < 0)
{
    Console.WriteLine("e negativo");
}
