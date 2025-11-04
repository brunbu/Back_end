using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string nome = "";
        public int Idade = 0;

        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}");
        }
        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade te que ser possitiva");
                return Idade;
            }

            Idade += _anos;

            return Idade;
        }
    }
}