// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um número: ");
double n1 = double.Parse(Console.ReadLine());

double dobro = n1 * 2;
double metade = n1 / 2;

Console.WriteLine($"O dobro de {n1} é {dobro}");    
Console.WriteLine($"A metade de {n1} é {metade}");