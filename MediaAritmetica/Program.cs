double primeiraNota = 0;
double segundaNota = 0;
double terceiraNota = 0;
double quartaNota = 0;

Console.WriteLine("Digite a primeira nota: ");
primeiraNota = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
segundaNota = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
terceiraNota = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
quartaNota = double.Parse(Console.ReadLine());

double mediaAritmetica = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;

Console.WriteLine("Sua média final é " + mediaAritmetica.ToString("N1"));