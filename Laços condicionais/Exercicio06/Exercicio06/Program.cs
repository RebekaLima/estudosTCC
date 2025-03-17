// See https://aka.ms/new-console-template for more information

int num1;
int num2;
int num3;

Console.WriteLine("Você irá digitar 3 números e o programa dirá qual o maior. ;)");

Console.WriteLine("Digite o primeiro número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
num3 = int.Parse(Console.ReadLine());

if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine("O " + num2 + " é o maior número!");
} else if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("O " + num1 + " é o maior número!");
} else if (num3 >= num1 && num3 >= num2)
{
    Console.WriteLine("O " + num3 + " é o maior número!");
} if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("Os valores dos números são iguais");
}
