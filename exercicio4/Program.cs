using System.Security.AccessControl;

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