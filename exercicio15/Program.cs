/*Faça um programa que receba 4 notas de aluno, calcule e imprima a média 
arti

*/
double n1, n2, n3, n4, media;
int continuar;
do
{

    Console.WriteLine("Digite a Primeira Nota");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Segunda Nota");
    n2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Terceira Nota");
    n3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Quarta Nota");
    n4 = double.Parse(Console.ReadLine());

    //
    media = (n1 + n2 + n3 + n4) / 4;
    Console.WriteLine("Media do Aluno = " + media);

    if (media >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else if (media >= 5)
    {
        Console.WriteLine("Recuperacao");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
    Console.WriteLine("Deseja continuar?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Não");
    continuar = int.Parse(Console.ReadLine());
} while (continuar == 1);

