// See https://aka.ms/new-console-template for more information
float salarioBruto;
float adicionalNoturno;
float horasExtras;
float descontos;
float salarioLiquido;

Console.WriteLine("Digite o valor do salário bruto: ");
salarioBruto = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o adicional noturno: ");
adicionalNoturno = float.Parse(Console.ReadLine());

Console.WriteLine("Digite as horas extras: ");
horasExtras = float.Parse(Console.ReadLine());

Console.WriteLine("Digite os valor total dos descontos: ");
descontos = float.Parse(Console.ReadLine());

salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - descontos;

Console.WriteLine("O valor do salário líquido é: " + salarioLiquido);
