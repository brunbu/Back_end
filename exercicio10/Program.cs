Console.Clear();//limpa tela
Console.WriteLine($"Digite seu nome:");//pede o nome do usuário
string nomeUsuario = Console.ReadLine();//guarda o nome na variável
Cumprimento(nomeUsuario);//chama a função e passa o nome


int opcao = -1;


void opcao1()
{
    Console.WriteLine($"Você escolheu a opção 1 - Exercicio1");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
double s, tg;

Console.WriteLine("Informe o seu Salario");
s = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o Total gasto");
tg = double.Parse(Console.ReadLine());

if (s > tg)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else if (s < tg)
{
    Console.WriteLine($"Orçamento estourado");
}


    
}

void opcao2()
{
    Console.WriteLine($"Você escolheu a opção 2 - Exercicio02");

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
double Pt, St;


Console.WriteLine("Informe o total de gols do primeiro time");
Pt= double.Parse(Console.ReadLine());
Console.WriteLine("Informe o total de gols do segundo time");
St= double.Parse(Console.ReadLine());


if (Pt > St)
{
    Console.WriteLine($"O Primeiro time venceu");
}
else if (Pt < St)
{
    Console.WriteLine($"O Segundo time venceu");
}
else if (Pt == St)
{
    Console.WriteLine($"O jogo Terminou em Empate");
}

}

void opcao3()
{
    Console.WriteLine($"Você escolheu a opção 3 - Exercicio03");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
double L1, L2, L3;

Console.WriteLine("Qual a medida do primeiro lado");
L1 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a medida do segundo lado");
L2 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a medida do terceiro lado");
L3 = double.Parse(Console.ReadLine());


if (L1 == L2 && L3 == L1)
    {
        Console.WriteLine("O Triângulo é Equilatero");
    }
    else if ((L1 == L2 && L1 != L3) || (L1 == L3 && L1 != L2) || (L2 == L3 && L2 != L1))
    {
        Console.WriteLine("O Triângulo é Isóceles");
    }
    else
    {
        Console.WriteLine("O Triângulo é Escaleno");
    }

}

void opcao4()
{
    Console.WriteLine($"Você escolheu a opção 4 - Exercicio04");
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
}
void opcao5()
{
    Console.WriteLine($"Você escolheu a opção 5 - Exercicio05");
            Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
int quantidade;
double preco;
Console.WriteLine("Digite o numero de maças");
quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 12)
{
    preco = 0.25;
}
else
{
    preco = 0.30;
}

 double total = quantidade * preco;

Console.WriteLine($"O valor total da compra é: R$ {total}");

}
void opcao6()
{
    Console.WriteLine($"Você escolheu a opção 6 - Exercicio06");
            Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("                  Seja Bem Vindo");
        Console.WriteLine("-------------------------------------------------------");
Console.Write("Digite a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno (em %): ");
        double frequencia = double.Parse(Console.ReadLine());
 if (frequencia < 75)
        {
            Console.WriteLine("Aluno REPROVADO por frequência.");
        }
        else if (media >= 7.0)
        {
            Console.WriteLine("Aluno APROVADO.");
        }
        else if (media >= 3.0)
        {
            Console.WriteLine("Aluno em RECUPERAÇÃO.");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO por média.");
        }


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
    Console.WriteLine(" 1 - Exercicio01");
    Console.WriteLine(" 2 - Execicio02");
    Console.WriteLine(" 3 - Execicio03");
    Console.WriteLine(" 4 - Execicio04");
    Console.WriteLine(" 5 - Execicio05");
    Console.WriteLine(" 6 - Execicio06");
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
        case 5:
            opcao5();
            break;
        case 6:
            opcao6();
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


