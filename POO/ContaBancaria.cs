namespace ExerciciosFundamentos.POO
{
//     🔹 POO em C#

// Exercício 1 – Sistema Bancário Simples

// Criar classe ContaBancaria com:

// Propriedades: Numero, Titular, Saldo.

// Métodos: Depositar(decimal valor), Sacar(decimal valor).

// Criar classe ContaCorrente que herda de ContaBancaria:

// Adicionar propriedade TaxaManutencao.

// Reescrever Sacar para cobrar taxa de R$1,00.

// Criar classe ContaPoupanca que herda de ContaBancaria:

// Adicionar propriedade TaxaJuros.

// Método AplicarJuros() que aumenta o saldo.

// 👉 Exercício bônus: Criar lista de contas (List<ContaBancaria>) e usar polimorfismo para sacar de diferentes contas.
public class ContaBancaria
{
    private string numero = string.Empty;

    public string Numero
    {
        get { return numero; }
        private set { numero = value; } // private set permite que apenas o construtor possa alterar o número da conta
    }
    private string titular = string.Empty;

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public decimal Saldo { get; protected set; } // protected set permite que apenas classes derivadas possam alterar o saldo

    public ContaBancaria(string numero, string titular, decimal saldoInicial = 0m)
    {
        if (string.IsNullOrWhiteSpace(numero)) throw new System.ArgumentException("Número inválido", nameof(numero));
        if (string.IsNullOrWhiteSpace(titular)) throw new System.ArgumentException("Titular inválido", nameof(titular));
        if (saldoInicial < 0m) throw new System.ArgumentException("Saldo inicial não pode ser negativo", nameof(saldoInicial));

        Numero = numero;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0m) throw new System.ArgumentException("Valor de depósito deve ser maior que zero", nameof(valor));
        if (valor > 0)
            Saldo += valor;
    }

    public virtual void Sacar(decimal valor) // virtual permite que o método seja sobrescrito em classes derivadas
    {
        if (valor > 0 && Saldo >= valor)
            Saldo -= valor;
    }
    public override string ToString()
    {
        return $"{GetType().Name} #{Numero} - {Titular} - Saldo: {Saldo:C}";
    }



}
}