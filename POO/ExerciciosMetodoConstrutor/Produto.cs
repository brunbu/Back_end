using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
         public string Nome;
        public int Preco;
        public int Estoque;

        public Produto()
        {
            Nome = "Descochecido";
            Preco = 0;
            Estoque = 0;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}, Preço: {Preco}, Estoque {Estoque}");
        }
    }
}