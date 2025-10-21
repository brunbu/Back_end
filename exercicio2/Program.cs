        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
double Pt, St;


Console.WriteLine("Informe o total de gols do primeiro time");
Pt= double.Parse(Console.ReadLine());
Console.WriteLine("Informe o total de gols do segundo time");
St= double.Parse(Console.ReadLine());


if (Pt > St)
{
    Console.WriteLine($"O Primeiro time venceu");
}
else if (Pt < St)
{
    Console.WriteLine($"O Segundo time venceu");
}
else if (Pt == St)
{
    Console.WriteLine($"O jogo Terminou em Empate");
}


