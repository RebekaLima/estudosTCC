// See https://aka.ms/new-console-template for more information
float num1;
float num2;
float num3;
float num4;
float calculo;

Console.WriteLine("Digite o primeiro número: ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
num3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto número: ");
num4 = float.Parse(Console.ReadLine());

calculo = (num1*num2) - (num3*num4);

Console.WriteLine("A diferença do produto entre n1 e n2 pelo produto entre n3 e n4 é: " + calculo);
