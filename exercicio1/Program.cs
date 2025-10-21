double s, tg;

Console.WriteLine("Informe o seu Salario");
s = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o Total gasto");
tg = double.Parse(Console.ReadLine());

if (s > tg)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else if (s < tg)
{
    Console.WriteLine($"Orçamento estourado");
}


