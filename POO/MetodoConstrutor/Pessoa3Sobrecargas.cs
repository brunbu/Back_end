using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
         public string Nome;
        public int Idade;
        /*Metodo construtor de Pessoa, possuindo paremetros
        Parametros representam valores para as suas respectivamente */
        public Pessoa3Sobrecargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        public Pessoa3Sobrecargas(string n)
        {
            Nome = n;
            Idade = 0;
        }
        public Pessoa3Sobrecargas(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}