namespace Ph.Bank
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;

        }
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                this.Saldo -= valorSaque;
                Console.WriteLine($"Olá {this.Nome}, Saque feito com sucesso!\nSaldo atual da conta é de {this.Saldo}");
                return true;
            }
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine($"Olá {this.Nome}, Deposito feito com sucesso!\nSaldo atual da conta é de {this.Saldo}");
        }

        public void Transferir(double valorTransf, Conta contaDestino)
        {
            if (this.Sacar(valorTransf) == true)
            {
                contaDestino.Depositar(valorTransf);
                Console.WriteLine($"Olá, Deposito de R${valorTransf} feito com sucesso para {contaDestino.Nome}!");
            }
            else Console.WriteLine("Saldo insuficiente");
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += " - TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito + "- \n";
            return retorno;
        }

    }
}