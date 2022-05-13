
int opçao;

Console.WriteLine("   Digite a opção desejada     ");
Console.WriteLine(" ============================= ");
Console.WriteLine("  1 - Pedido para entrega.     ");
Console.WriteLine(" ============================= ");
Console.WriteLine("  2 - Pegar no balcão.         ");
Console.WriteLine(" ============================= ");
Console.WriteLine("  3 - Falar com atendente      ");
Console.WriteLine(" ============================= ");
Console.WriteLine("  4 - Encerrar.                ");
Console.WriteLine(" ============================= ");

Console.Write("> ");

opçao = int.Parse(Console.ReadLine());

switch (opçao)
{
    case 1:
        Console.WriteLine("Em breve estaremos entregando seu pedido.");
        break;

    case 2:
        Console.WriteLine("Seu pedido estará pronto em 30 minutos.");
        break;

    case 3:
        Console.WriteLine("Olá, em que posso servi-lo?");
        break;

    case 4:
        Console.Clear();

        Console.WriteLine(" ============================ ");
        Console.WriteLine("  Obrigado pela preferência   ");
        Console.WriteLine(" ============================ ");
        break;

    default:
        Console.WriteLine("Nenhuma das opções é válida");
        break;

}

