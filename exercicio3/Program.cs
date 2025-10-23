        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
double L1, L2, L3;

Console.WriteLine("Qual a medida do primeiro lado");
L1 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a medida do segundo lado");
L2 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a medida do terceiro lado");
L3 = double.Parse(Console.ReadLine());


if (L1 == L2 && L3 == L1)
    {
        Console.WriteLine("O Triângulo é Equilatero");
    }
    else if ((L1 == L2 && L1 != L3) || (L1 == L3 && L1 != L2) || (L2 == L3 && L2 != L1))
    {
        Console.WriteLine("O Triângulo é Isóceles");
    }
    else
    {
        Console.WriteLine("O Triângulo é Escaleno");
    }
