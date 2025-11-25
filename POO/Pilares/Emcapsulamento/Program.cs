using Emcapsulamento;
Console.Clear();
// float dinheiro = 200;

// ContaBancaria contaBruno = new ContaBancaria();
// ContaBancaria contaBarney = new ContaBancaria();


// contaBruno.Depositar (dinheiro);
// System.Console.WriteLine($"Novo saldo do Bruno: R${contaBruno.getSaldo()}");
// System.Console.WriteLine("------------------");
// contaBarney.Depositar (dinheiro);
// System.Console.WriteLine($"Novo saldo do Barney: R${contaBarney.getSaldo()}");
// System.Console.WriteLine("------------------");
// contaBruno.Sacar(100);
// System.Console.WriteLine($"Novo saldo do Bruno: R${contaBruno.getSaldo()}");
// System.Console.WriteLine("------------------");
// contaBarney.Sacar(50);
// System.Console.WriteLine($"Novo saldo do Barney: R${contaBarney.getSaldo()}");

Carro carro1 = new Carro();
carro1.DefinirMarca("Toyota");
carro1.DefinirModelo("Corolla 94");

carro1.velocidadeAtualizar(100);
System.Console.WriteLine($"Marca: {carro1.ObterMarca()}");
System.Console.WriteLine($"Modelo: {carro1.ObterModelo()}");
System.Console.WriteLine($"Velocidade Atual: {carro1.ObterVelocidadeAtual()} km/h");
System.Console.WriteLine($"Freando 30 km/h...");
carro1.Frear(30);
System.Console.WriteLine($"Velocidade atual apos frear: {carro1.ObterVelocidadeAtual()} km/h");



