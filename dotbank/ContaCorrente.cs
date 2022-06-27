namespace dotbank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else { 
            saldo = saldo + valor;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
    }
}