// See https://aka.ms/new-console-template for more information


Console.WriteLine("Digite uma palavra: ");
string p = Console.ReadLine();

Console.WriteLine("Quantas vezes quer repetir ela? ");
int rep = int.Parse(Console.ReadLine());

for (int i = 1; i <= rep; i++)
{
    Console.WriteLine($"{i}  -  {p}");
}
