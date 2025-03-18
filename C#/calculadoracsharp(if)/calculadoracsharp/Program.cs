// See https://aka.ms/new-console-template for more information
float num;
float num1;
float result;
string operacao;
string resposta;

Console.WriteLine("Seja bem-vindo a calculadora!");

do {

    Console.WriteLine("Digite o primeiro número: ");
    num = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o sinal da operação (+, -, *, +): ");
    operacao = Console.ReadLine();

    Console.WriteLine("Digite o segundo número: ");
    num1 = float.Parse(Console.ReadLine());

    if (operacao == "+")
    {
        result = num + num1;
        Console.WriteLine("O resultado é: " + result);
    } else if (operacao == "-")
    {
        result = num - num1;
        Console.WriteLine("O resultado é: " + result);
    } else if (operacao == "*")
    {
        result = num * num1;
        Console.WriteLine("O resultado é " + result);
    } else if (operacao == "/")
    {
        result = num / num1;
        Console.WriteLine("O resultado é " + result);
    } else
    {
        Console.WriteLine("Operação inválida!");
    }

    Console.WriteLine("Deseja iniciar uma nova operação? Digite 'sim' para continuar ou digite outro caractere para finalizar!");
    resposta = Console.ReadLine();

} while (resposta == "sim") ;

Console.WriteLine("Programa encerrado!");