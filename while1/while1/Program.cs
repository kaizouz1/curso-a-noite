// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main()
    {
        int numeroSecreto = 8;
        Console.Write("Adivinhe o número secreto: ");
        int palpite = int.Parse(Console.ReadLine());
       
       while (palpite != numeroSecreto)
        {
            Console.WriteLine("Tente novamente!");
            Console.Write("Digite outro número: ");
            palpite = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Parabens, Você acertou o número secreto!");
    }
}