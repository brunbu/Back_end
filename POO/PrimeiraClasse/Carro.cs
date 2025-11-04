
namespace PrimeiraClasse
{
    public class Carro

    {
        public int qtdPortas;
        public int qtdRodas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine($"Carro Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Carro Ligando");
        }

        public void Desligar()
        {
            Console.WriteLine($"Carro Deslingando");
        }
    }
}