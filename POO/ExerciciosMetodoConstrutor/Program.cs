using ExerciciosMetodoConstrutor;

// Carro c1 = new Carro("Toyota", "Corrola", 1994);
// c1.ExibirDados();
// Console.WriteLine();

//-----------------------------------------------------------------------------//


// Aluno a1 = new Aluno();
// Aluno a2 = new Aluno("Bruno", 7);


// System.Console.WriteLine(@$"Aluno 1:
// Nome: {a1.Nome}
// Nota: {a1.Nota}");

// System.Console.WriteLine();

// System.Console.WriteLine(@$"Aluno 2:
// Nome: {a2.Nome}
// Nota: {a2.Nota}");


//-------------------------------------------------------//

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Lucas";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Samuel";
a2.Media();