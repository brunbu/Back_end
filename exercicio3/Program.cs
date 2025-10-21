        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
double TrianguloEquilátero, TrianguloIsoscele, TrianguloEscaleno;

Console.WriteLine("Qual a medida do primeiro lado");
TrianguloEquilátero = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a medida do segundo lado");
TrianguloIsoscele = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a medida do terceiro lado");
TrianguloEscaleno = double.Parse(Console.ReadLine());


if (TrianguloEquilátero == 3)
{
    Console.WriteLine("Triângulo    Equilátero:    possui    os    3    lados    iguais.");
}
else if (TrianguloIsoscele == 2)
{
    Console.WriteLine("Triângulo    Isóscele:    possui    2    lados    iguais.     ");
}
else if (TrianguloEscaleno == 3)
{
    Console.WriteLine("Triângulo    Escaleno:    possui    3    lados    diferentes.");
}
