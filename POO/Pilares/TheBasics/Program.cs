using System.Runtime.ConstrainedExecution;
using TheBasics;
Console.Clear();

// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecoBruno = new Endereco();
// enderecoBruno.Logradouro = "Rua JUbileu";
// Pessoa Bruno = new Pessoa(enderecoBruno);
// Bruno.Nome = "Bruno";
// Bruno.Idade = 16;

// Endereco enderecoZoio = new Endereco();
// enderecoZoio.Logradouro = "Rua Casa do Zoio";
// Pessoa Zoio = new Pessoa(enderecoZoio);
// Zoio.Nome = "Olhos Azuis";
// Zoio.Idade = 36;

// Endereco enderecoBarney = new Endereco();
// enderecoBarney.Logradouro = "Rua Estrada Das Lagrimas";
// Pessoa Barney = new Pessoa(enderecoBarney);
// Barney.Nome = "Mateus Latorre";
// Barney.Idade = 16;

// Endereco enderecoFontes = new Endereco();
// enderecoFontes.Logradouro = "Rua Não sei";
// Pessoa Fontes = new Pessoa(enderecoFontes);
// Fontes.Nome = "Felipes Fontes";
// Fontes.Idade = 18;

// peoples.Add(Bruno);
// peoples.Add(Zoio);
// peoples.Add(Barney);
// peoples.Add(Fontes);



// System.Console.WriteLine($"Pessoa 1: {peoples[0].Nome}");
// System.Console.WriteLine();

// System.Console.WriteLine($"Pessoa 2: {peoples[1].Nome}");
// System.Console.WriteLine();

// System.Console.WriteLine($"Pessoa 3: {peoples[2].Nome}");
// System.Console.WriteLine();

// System.Console.WriteLine($"Pessoa 4: {peoples[3].Nome}");
// System.Console.WriteLine();




// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistema";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlexia = new Endereco();
// endProfAlexia.Logradouro = "Rua lá de Casa";
// endProfAlexia.Numero = 987;

// Professor professorAlexia = new Professor(endProfAlexia);
// professorAlexia.Nome = "Aléxia Vitoria";

// System.Console.WriteLine($"Aluno{pedroEnzo.Nome}estuda na turma{pedroEnzo.Curso} da profa.");

Carro c1 = new Carro();
c1.Marca = "Toyota";
c1.Modelo = "Corrolla";
c1.QtdRodas = 4;

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Marca = "Dominar 400";

c1.Ligar();
c1.AbrirPortaMala();

dominar400.Ligar();
dominar400.Empinar();