// See https://aka.ms/new-console-template for more information



Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());


if (n1 > 0)
{
    Console.WriteLine("O número é positivo.");  
}
else if (n1  < 0)
{
    Console.WriteLine("O número é negativo.");
}
else
{
    Console.WriteLine("O número é zero.");
}

