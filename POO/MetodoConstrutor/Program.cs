// using MetodoConstrutor;

// Pessoa fontes = new Pessoa("João", 17);

// // fontes.Nome = "Felipe Fontes";
// // fontes.Idade = 17;

// System.Console.WriteLine(@$"O objeto pessoa que criei é o {fontes.Nome} com  
// {fontes.Idade} anos");

// //fontes.Nome = "Gustavo Oliveira";

// System.Console.WriteLine($"{fontes.Nome}");

// //fontes.Nome = "Henrique";
// fontes.ExibirDados();

// System.Console.WriteLine($"{fontes.Nome}");

using MetodoConstrutor;
//primeiro
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();
System.Console.WriteLine(@$"Primeira Pessoa cadastra:
                            Nome: {PrimeiraPessoa.Nome}                        
                            Idade: {PrimeiraPessoa.Idade}
                            
");
//segundo
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Mateus Latore");
System.Console.WriteLine(@$"Segunda Pessoa cadastra:
                            Nome: {SegundaPessoa.Nome}                        
                            Idade: {SegundaPessoa.Idade}
                            
");
//terceiro
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Fontes", 17);
Console.WriteLine("Qual o nome da Terceira Pessoa");
TerceiraPessoa.Nome = Console.ReadLine();
System.Console.WriteLine("Qual a idade da Terceira Pessoa");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine(@$"Terceira Pessoa cadastra:
                            Nome: {TerceiraPessoa.Nome}                        
                            Idade: {TerceiraPessoa.Idade}
                            
");