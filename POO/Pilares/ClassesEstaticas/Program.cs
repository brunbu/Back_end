// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;
Console.Clear();
Console.WriteLine("Bem Vindo ao Progama");
System.Console.WriteLine();

// System.Console.WriteLine("Digite um numero:");
// float a = float.Parse(Console.ReadLine());
// System.Console.WriteLine("Digite outro numero:");
// float b = float.Parse(Console.ReadLine());


// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"O Resultado da Soma é: {r}");
// r = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"O Resultado da Subtração é: {r}");
// r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"O Resultado da Multiplicação é: {r}");
// r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"O Resultado da Divisão é: {r}");

// System.Console.WriteLine($"VAlor do PI é: {Math.PI}");
// System.Console.WriteLine($"Potencia de 3 elevado a 2 é: {Math.Pow(3,2)}");

System.Console.WriteLine("Digite um numero:");
float a = float.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite outro numero:");
float b = float.Parse(Console.ReadLine());

if (a == b)
{
    System.Console.WriteLine("Os numeros são iguais");
}
else
{
System.Console.WriteLine($"O maior valor entre {a} e {b} é: {Math.Max(a, b)}");
System.Console.WriteLine($"O menor valor entre {a} e {b} é: {Math.Min(a, b)}");
}

