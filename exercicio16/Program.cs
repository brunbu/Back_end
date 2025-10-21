string Cargo ;
double Salario, SalarioReajuste = 0;

Console.WriteLine("Qual o Cargo do Funcionario");
Cargo = Console.ReadLine();
Console.WriteLine("Digite o Salario do Funcionario");
Salario = double.Parse(Console.ReadLine());



if (Cargo == "Producao")
{
    SalarioReajuste = Salario * 1.065;
}
else if (Cargo == "Administrativo")
{
    SalarioReajuste = Salario * 1.075;
}
else if (Cargo == "Diretoria")
{
    SalarioReajuste = Salario * 1.12;
}
else
{
        SalarioReajuste = Salario;
        Console.WriteLine("Cargo invalido , sem reajuste");    
}
Console.WriteLine("Seu salário reajustado é de R$" + (SalarioReajuste));
Console.WriteLine("");
Console.WriteLine("");