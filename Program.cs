using System;
using ExerciciosFundamentos.EstruturasDados;

class Program
{
    static void Main()
    {
        var historico = new Pilha<string>();

        historico.Push("Página 1");
        historico.Push("Página 2");
        historico.Push("Página 3");

        Console.WriteLine("Página atual: " + historico.Peek());

        Console.WriteLine("Voltando de: " + historico.Pop());
        Console.WriteLine("Agora em: " + historico.Peek());
    }
}
