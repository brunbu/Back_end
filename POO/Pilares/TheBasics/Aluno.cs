
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}