using System.Diagnostics.Contracts;

namespace ExerciciosFundamentos.POO
{
    public class ContaCorrente : ContaBancaria // ContaCorrente herda de ContaBancaria
   {
       public ContaCorrente(string numero, string titular, decimal saldoInicial = 0)
       : base(numero, titular, saldoInicial) // chama o construtor da classe base
       {
         TaxaManutencao = 1.00M;
       }
      public decimal TaxaManutencao {get; set;}
    
      public override void Sacar(decimal valor) // override sobrescreve o método Sacar da classe base
        {
          decimal totalASacar = TaxaManutencao + valor;

          if (valor > 0 && Saldo >= totalASacar )
           {
             Saldo -= totalASacar;

           }

        }
   } 
}
