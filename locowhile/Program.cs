using System.Diagnostics.Contracts;
int contador = 1;
while ( contador <= 3)
{
    Console.WriteLine($"Hello, World {contador}");
    
    contador++;
}

Console.WriteLine($"fora do laço: {contador}");