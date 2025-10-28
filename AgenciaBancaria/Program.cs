 Console.Clear();
string[] nomes = new String[3];
double[] saldos = new double[3];
int totalClientes = 0;
int opcao = -1;


do
{
    Console.WriteLine("====================================");
    Console.WriteLine("$         Bem vindo    ");
    Console.WriteLine("$             Ao    ");
    Console.WriteLine("$    Sistema da Agencia Bancaria    ");
    Console.WriteLine("====================================");
    Console.WriteLine("");

    Console.WriteLine("===============================");
    Console.WriteLine($"Escolha uma das opções abaixo:");
    Console.WriteLine($"1- Cadastrar Cliente");
    Console.WriteLine($"2- Depositar");
    Console.WriteLine($"3- Sacar");
    Console.WriteLine($"4- Transferir");
    Console.WriteLine($"5- Listar Clientes");
    Console.WriteLine($"0- Sair");
    Console.WriteLine($"==============================");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    switch (opcao)
    {
        case 0:
            Sair();
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            Console.WriteLine($"Pressione <Enter> para continuar...");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("ERRO: A opção escolhida não existe.");
            break;
    }
} while (opcao != 0);

void CadastrarCliente()
{
    if (totalClientes >= 3)
    {
        Console.WriteLine("Limite de clientes atingido");
        Console.WriteLine($"Pressione <Enter> para encerrar...");
        Console.ReadLine();
        return;
    }
    Console.WriteLine("Digite o nome do Cliente");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine("Cliente cadastrado com sucesso");
    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();
}
void Depositar()
{
    Console.WriteLine($"Qual cliente deseja fazer o deposito: ");

    ListarClientes();
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o quanto deseja depositar");
    saldos[n - 1] += double.Parse(Console.ReadLine());
    Console.WriteLine("Saldo depositado com sucesso");

    Console.WriteLine($"O saldo atual de {nomes[n - 1]} é de R${saldos[n - 1]}");
    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();
}
void Sacar()
{
    Console.WriteLine($"Qual cliente deseja fazer o saque: ");

    ListarClientes();
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o quanto deseja sacar");
    saldos[n - 1] -= double.Parse(Console.ReadLine());
    Console.WriteLine("Saldo sacado com sucesso");

    Console.WriteLine($"O saldo atual de {nomes[n - 1]} é de R${saldos[n - 1]}");
    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();
}
void Transferir()
{
    Console.WriteLine($"Qual cliente deseja Transferir: ");
    ListarClientes();
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o quanto deseja transferir");
    double transferir = double.Parse(Console.ReadLine());
    saldos[n - 1] -= transferir;

    Console.WriteLine($"Qual cliente irá receber a transferência : ");
    ListarClientes();
    int t = int.Parse(Console.ReadLine());
    saldos[t - 1] += transferir;
    Console.WriteLine("Saldo transferido com sucesso com sucesso");

    Console.WriteLine($"O saldo atual de {nomes[t - 1]} é de R${saldos[t - 1]}");
    Console.WriteLine($"O saldo atual de {nomes[n - 1]} é de R${saldos[n - 1]}");
    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();
}
void ListarClientes()
{
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i + 1}- {nomes[i]} | Saldo atual: R${saldos[i]} ");
    }

}
void Sair()
{
    Console.WriteLine("=======================================");
    Console.WriteLine("      Obrigado por usar Até mais       ");
    Console.WriteLine("=======================================");
}




