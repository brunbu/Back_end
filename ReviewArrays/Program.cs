using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
Console.Clear();
string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;


// nomes[0] = "Maria";
// idades[0] = 17;
// nomes[1] = "Matheus";
// idades[1] = 16;
// nomes[2] = "Eloysa";
// idades[2] = 17;
// nomes[3] = "Felipe";
// idades[3] = 16;


do
{
    Console.WriteLine($"1) Cadastrar Aluno");
    Console.WriteLine($"2) Listar Aluno");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite um opção");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine();
            break;
        case 1:
            CadastrarAluno();
            break;
        case 2:
            ListarAlunos();
            break;
        default:
            Console.WriteLine($"opção invalida, pressione <Enter> para continuar ...");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);

void CadastrarAluno()
{
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingindo");
        Console.WriteLine($"Pressione <Enter> para continuar");
        return;
    }
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Alunos cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} alunos(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();

}while (opcao != 0);



//
void ListarAlunos()
{
Console.WriteLine();
Console.WriteLine($"Resultado: ");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"    Nome:{nomes[i]}");
        Console.WriteLine($"    idade: {idades[i]} anos");
        Console.WriteLine();//pula linha
    }

}