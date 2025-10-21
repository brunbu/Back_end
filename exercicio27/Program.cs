int numero = 0, i = 1, quantidade = 1;

Console.WriteLine("Quantos numeros vc quer digitar");
quantidade = int.Parse (Console.ReadLine());


while (i <= quantidade)
{
    Console.WriteLine("Qual numero vc quer digitar");
    numero = int.Parse(Console.ReadLine());
    if (numero %2 == 0)
   {
    Console.WriteLine($"Numero digitado é par: {numero}");
   }

    numero++;
}
