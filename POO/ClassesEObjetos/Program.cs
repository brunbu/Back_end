// using ClassesEObjetos;

// Console.WriteLine($"Vamos Fazer sua garrafa");

// Garrafa g1 = new Garrafa();
// Console.WriteLine($"Qual cor ela vai ser?");
// g1.cor = Console.ReadLine();

// Console.WriteLine("Qual a capacidade de agua da garrafa? (em ml)");
// g1.capacidade = int.Parse(Console.ReadLine());

// Console.WriteLine($"Qual a marca da garrafa?");
// g1.marca = Console.ReadLine();

// Console.WriteLine($"Qual o modelo da garrafa?");
// g1.modelo = Console.ReadLine();;


// Console.WriteLine($"");
// Console.WriteLine($"Características");
// Console.WriteLine($"");

// Console.WriteLine($"-------- {g1.marca} --------");


// Console.WriteLine($"Cor: {g1.cor}");
// Console.WriteLine($"Capacidade: {g1.capacidade}");
// Console.WriteLine($"Marca: {g1.marca}");
// Console.WriteLine($"Modelo: {g1.modelo}");
// Console.WriteLine($"");
// Console.WriteLine($"---");
// Console.WriteLine($"");

// Console.WriteLine($"Abrindo a garrafa {g1.marca}");
// Console.WriteLine($"Enchendo a garrafa {g1.marca}");
// Console.WriteLine($"Esvaziando a garrafa {g1.marca}");
// Console.WriteLine($"Fechando a garrafa {g1.marca}");

using ClassesEObjetos;

Console.WriteLine($"Digite o nome do titular da conta: ");
string nomeT= Console.ReadLine();

AgenciaBancária conta = new AgenciaBancária(nomeT);

Console.WriteLine();
Console.WriteLine($"Bem vindo, {conta.Titular}");
Console.WriteLine($"Saldo inicial: R$ {conta.Titular:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1 - depositar");
    Console.WriteLine($"2 - Sacar");
    Console.WriteLine($"0 - Sair");

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Digite o valor do deposito: R$");
            double depositado = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(depositado);
            break;


        case 2:
            Console.WriteLine($"Digite o valor que quer sacar: R$");
            double Saque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(Saque);
            break;
        case 0:
            Console.WriteLine($"Saindo.");
            break;
        default:
            Console.WriteLine($"Opção invalida, escolhe uma das opções acima.");
            break;
    }
} while (opcao != 0);


// using ClassesEObjetos;
// Console.Clear();
// Pessoa joao = new Pessoa();
// joao.nome = "João";
// joao.Idade = 0;

// Console.WriteLine($"{joao.nome} tem {joao.Idade} anos");

// joao.Envelhecer(17);

// Console.WriteLine($"{joao.nome} tem {joao.Idade} anos");
// joao.Envelhecer(-50);
// Console.WriteLine($"{joao.nome} tem {joao.Idade} anos");