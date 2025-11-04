
namespace PrimeiraClasse
{
    public class Hello
    {
        // Propriedades/Caracteristicas - variáveis internas dessa classe 
    public string Textohello = "";

        // Métodos/Comportamentos/ Ações - são as funções 
        public void SaldarUsuario()
        {
            Console.WriteLine(Textohello);
        }
        public void SaldarNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    
    }
}