
double numero;
Console.Write("Digite o número da tabuada: ");
numero = double.Parse(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("Número inválido");
}
else
{
    int parametro;
    Console.Write("Digite um número inteiro indicando até onde vai rodar a sua tabuada: ");
    parametro = int.Parse(Console.ReadLine());

    for (int i = 0; i <= parametro; i++)
    {
        double total = numero * i;
        Console.WriteLine(numero + " X " + i + " = " + total);

    }
}