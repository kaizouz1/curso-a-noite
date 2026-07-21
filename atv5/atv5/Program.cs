// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite uma medida em metros: ");
double metros = double.Parse(Console.ReadLine());

double centimetros = metros * 100;
Console.WriteLine($"{metros} metros equivalem a {centimetros} centimetros")
