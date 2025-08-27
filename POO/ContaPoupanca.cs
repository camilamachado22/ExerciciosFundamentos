using System.Dynamic;
namespace ExerciciosFundamentos.POO
{
    public class ContaPoupanca : ContaBancaria // ContaPoupanca herda de ContaBancaria
    {
        public ContaPoupanca(string numero, string titular, decimal saldoInicial = 0)
            : base(numero, titular, saldoInicial) // chama o construtor da classe base
        {
            TaxaRendimento = 0.05M; // 5% de rendimento mensal
        }

        public decimal TaxaRendimento { get; set; }

        public void AplicarJuros()
        {
            if (Saldo > 0)
            {
                Saldo += Saldo * TaxaRendimento;
            }
        }
    }
}

