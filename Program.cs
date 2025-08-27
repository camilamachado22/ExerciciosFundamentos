using System;
using System.Collections.Generic;
using ExerciciosFundamentos.POO;

class Program
{
    static void Main()
    {
        // Teste individual
        var cc = new ContaCorrente("001", "Camila", 1000m);
        cc.Depositar(200m);
        Console.WriteLine(cc);
        try
        {
            cc.Sacar(100m); // cobra taxa de 1.00
            Console.WriteLine("Após saque: " + cc);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        var cp = new ContaPoupanca("002", "Marcos", 500m);
        Console.WriteLine(cp);
        cp.AplicarJuros(); // aplica 5%
        Console.WriteLine("Após aplicar juros: " + cp);

        // Demonstrando polimorfismo: lista de ContaBancaria com tipos diferentes
        List<ContaBancaria> contas = new List<ContaBancaria> { cc, cp, new ContaCorrente("003","Ana", 50m) };

        Console.WriteLine("\n-- Tentando sacar R$100 de cada conta via polimorfismo --");
        foreach (var conta in contas)
        {
            Console.WriteLine($"Antes: {conta}");
            try
            {
                // Cada implementação de Sacar será chamada conforme o tipo real do objeto
                conta.Sacar(100m);
                Console.WriteLine($"Saque realizado. Depois: {conta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível sacar em {conta.Numero}: {ex.Message}");
            }
        }
    }
}
