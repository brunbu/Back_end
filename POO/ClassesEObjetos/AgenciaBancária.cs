namespace ClassesEObjetos
{
    public class AgenciaBancária
    {
        public string titular = "";
        public int saldo = 0;

        public void Depositar()
        {
            Console.WriteLine($"Aumentado");
            return;
        }
        public void Sacar()
        {
            Console.WriteLine($"Diminuido");
            return;
        }
        
    }
}