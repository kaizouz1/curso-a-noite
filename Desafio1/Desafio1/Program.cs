Console.WriteLine("Digite o primeiro lado:");
double lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado:");
double lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado:");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 < lado2 + lado3 || lado2 < lado1 + lado3 || lado3 < lado1 + lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo equilátero.");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo isósceles.");
    }
    else
    {
        Console.WriteLine("Triângulo escaleno.");
    }
}
else
{
    Console.WriteLine("Os valores não formam um triângulo.");
}