// See https://aka.ms/new-console-template for more information

Console.Write("Nota 1: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
double n3 = double.Parse(Console.ReadLine());

Console.Write("Nota 4: ");
double n4 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3 + n4) / 4;
Console.WriteLine($"A média final foi: {media}");

if (media >= 7.0)
{
    Console.WriteLine("Status: Aprovado!");
}
else
{
    Console.WriteLine("Status: Recuperação.");
}
