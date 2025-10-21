using System.Security.AccessControl;
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
int senha = 1234;


Console.Clear();
Console.WriteLine("Qual a senha?");
senha = int.Parse(Console.ReadLine());




if (senha == 1234)
{
    Console.Write("Acesso Permitido");

}
else 
{
    Console.Write("Acesso Negado");
}