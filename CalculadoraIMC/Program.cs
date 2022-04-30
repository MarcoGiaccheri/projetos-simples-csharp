double peso = 0;
double altura = 0;

Console.WriteLine("Digite seu peso (kg)");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura (metros)");
altura = double.Parse(Console.ReadLine());

double imc = (peso / (altura * altura));

Console.WriteLine($"Se você pesa {peso} Kg e mede {altura.ToString("N2")} metros de altura seu imc é {imc.ToString("N1")}");