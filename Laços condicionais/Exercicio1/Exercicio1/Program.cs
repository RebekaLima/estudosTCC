// See https://aka.ms/new-console-template for more information
int valorA;
int valorB;
int valorC;

Console.WriteLine("Digite um valor A: ");
valorA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor B: ");
valorB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor C: ");
valorC = int.Parse(Console.ReadLine());

if (valorA + valorB >  valorC)
{
    Console.WriteLine("A soma de A + B é maior do que C");
} if (valorA + valorB < valorC)
{
    Console.WriteLine("A soma de A + B é menor do que C");
} if (valorA + valorB == valorC)
{
    Console.WriteLine("A soma de A + B é o mesmo valor de C");
}