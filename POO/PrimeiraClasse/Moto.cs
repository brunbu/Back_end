using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Moto
    {
        public string cor = "";
        public string modelo = "";
        public int qtdRodas;
        public string marca = "";

        public void Acelerar()
        {
            Console.WriteLine($"Vruuuuuuuuum tu tu tu");
        }

        public void Ligar()
        {
            Console.WriteLine($"Vrum, Vrum ...");
        }

        public void Desligar()
        {
            Console.WriteLine($"Deslingando a moto");
        }

    }
}