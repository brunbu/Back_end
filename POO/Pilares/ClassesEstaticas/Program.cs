// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

Console.WriteLine("Bem Vindo ao Progama");
System.Console.WriteLine();

System.Console.WriteLine("Digite um numero:");
float a = float.Parse(Console.ReadLine());
System.Console.WriteLine("Digite outro numero:");
float b = float.Parse(Console.ReadLine());


float r = CalculosMatematicos.Somar(a, b);
System.Console.WriteLine($"O Resultado da Soma é: {r}");
r = CalculosMatematicos.Subtrair(a, b);
System.Console.WriteLine($"O Resultado da Subtração é: {r}");
r = CalculosMatematicos.Multiplicar(a, b);
System.Console.WriteLine($"O Resultado da Multiplicação é: {r}");
r = CalculosMatematicos.Dividir(a, b);