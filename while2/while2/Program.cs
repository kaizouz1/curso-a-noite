// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite uma nota entre 0.0 e 10.0:");
double nota = double.Parse(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida! Digite uma nota entre 0.0 e 10.0:");
    nota = double.Parse(Console.ReadLine());
}

Console.WriteLine("Nota valida!");
