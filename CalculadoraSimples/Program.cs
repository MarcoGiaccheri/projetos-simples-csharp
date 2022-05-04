double primeiroNumero = 0;
double segundoNumero = 0;
double resultado = 0;
char tipoOperaçao;

Console.WriteLine("Digite o primeiro número: ");
primeiroNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
segundoNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o tipo de operação desejada (+, -, *, /): ");
tipoOperaçao = char.Parse(Console.ReadLine());

if (tipoOperaçao == '+')
{
    resultado = primeiroNumero + segundoNumero;
}
else if (tipoOperaçao == '-')
{
    resultado = primeiroNumero - segundoNumero;
}
else if (tipoOperaçao == '*')
{
    resultado = primeiroNumero * segundoNumero;
}
else if (tipoOperaçao == '/')
{
    resultado = primeiroNumero / segundoNumero;
}

Console.WriteLine("O resultado é:" + resultado);