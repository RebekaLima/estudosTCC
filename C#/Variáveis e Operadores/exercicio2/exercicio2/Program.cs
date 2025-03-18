// See https://aka.ms/new-console-template for more information
float nota1;
float nota2;
float nota3;
float nota4;
float media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
nota4 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4)/4;

Console.WriteLine("A média das notas é: " + media);
