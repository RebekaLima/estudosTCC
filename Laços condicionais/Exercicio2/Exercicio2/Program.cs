// See https://aka.ms/new-console-template for more information
int idade; // variável que vai receber a idade

Console.WriteLine("Digite a sua idade: "); // mensagem ao usuário
idade = int.Parse(Console.ReadLine()); // vai receber a entrada

if  (idade >= 18) //se a idade for maior ou igual a 18
{
    Console.WriteLine("Você é maior de idade");
} else // se a idade não for maior ou igual a 18
{
    Console.WriteLine("Você é menor de idade");
}
