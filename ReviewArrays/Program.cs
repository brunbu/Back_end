Console.Clear();//limpa tela
Console.WriteLine($"Digite seu nome:");//pede o nome do usuário
string nomeUsuario = Console.ReadLine();//guarda o nome na variável
Cumprimento(nomeUsuario);//chama a função e passa o nome


int opcao = -1;


void opcao1()
{
    Console.WriteLine($"Você escolheu a opção 1 - Coxinha");
}

void opcao2()
{
    Console.WriteLine($"Você escolheu a opção 2 - Pastel");
}

void opcao3()
{
    Console.WriteLine($"Você escolheu a opção 3 - Caldo de Cana");
}

void opcao4()
{
    Console.WriteLine($"Você escolheu a opção 4 - Bolo de Chocolate");
}

void opcao0()
{
    Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
}

void opcaoinvalida()
{
    Console.WriteLine($"Não temos esta opção {opcao} !!");
}

do
{//todo o programa aqui dentro
 //desenha um menu de opções
    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine(" 1 - Coxinha");
    Console.WriteLine(" 2 - Pastel");
    Console.WriteLine(" 3 - Caldo de Cana");
    Console.WriteLine(" 4 - Bolo de Chocolate");
    Console.WriteLine(" 0 - Sair");
    //captura a opção do usuário
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            opcao1();
            break;
        case 2:
            opcao2();
            break;
        case 3:
            opcao3();
            break;
        case 4:
            opcao4();
            break;
        case 0:
            opcao0();
            break;
        default:
            opcaoinvalida();
            break;
    }
} while (opcao != 0) ;

Console.Clear();
Console.WriteLine($"FIM DO PROGRAMA");



// tipoDeDado Nome (parâmetros){corpo}
void Cumprimento(string n)
{
    Console.WriteLine($"Olá, {n}");
}
