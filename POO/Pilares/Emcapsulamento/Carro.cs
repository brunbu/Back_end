using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emcapsulamento
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private int velocidadeAtual;

        public void DefinirMarca(string marca)
        {
            this.marca = marca;
        }
        public string ObterMarca()
        {
            return marca; 
        }
        public void DefinirModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string ObterModelo()
        {
            return modelo; 
        }
        public void velocidadeAtualizar(int velocidade)
        {
            if (velocidade >= 0)
            {
                velocidadeAtual = velocidade;
            }
            else
            {
                System.Console.WriteLine("Velocidade inválida");
            }
        }
        public int ObterVelocidadeAtual()
        {
            return velocidadeAtual;
        }
        public void Acelerar(int Valor)
        {
            if (Valor > 0)
            {
                velocidadeAtual += Valor;
            }
            else
            {
                System.Console.WriteLine("Valor inválido para acelerar");
            }
        }
        public void Frear(int Valor)
        {
            if (Valor > 0)
            {
                velocidadeAtual -= Valor;
                if (velocidadeAtual < 0)
                {
                    velocidadeAtual = 0;
                }
            }
            else
            {
                System.Console.WriteLine("Valor inválido para frear");
            }
        }
        
    }

}