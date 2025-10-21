int n1 = 0, n2 = 0, i = 1, q = 0;

Console.WriteLine("digite o numero de repeticao");
q = int.Parse (Console.ReadLine());


while (i <= q)
{
    Console.WriteLine("digite o primeiro  numero");
    n1 = int.Parse (Console.ReadLine());
    Console.WriteLine("digite o segundo numero");
    n2 = int.Parse(Console.ReadLine());
    if (n1 > n2)
    {
        Console.WriteLine($"o numero {n1} e maior que {n2}");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"o numero {n1} e menor que {n2}");
    }
    else
    {
        Console.WriteLine($"Os dois numeros sao iguais: {n1} = {n2}");
    }
    i++;
}

