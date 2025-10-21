/*
Pedir o nome do usuario,
Pedir dois número e
mostra a soma dos numeros no final
*/

string nome;
int numero1;
int numero2;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();//pede o nome do usuario

//pedir os dois numeros
Console.WriteLine("Digite o primeiro número");
numero1 =int.Parse (Console.ReadLine());
Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());

//somar os dois numeros
int soma = numero1 + numero2;


// exibir nome e a soma
Console.WriteLine(nome);
Console.WriteLine(soma);