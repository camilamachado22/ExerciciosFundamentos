using System;
using System.Collections.Generic;

public class Fila<T>
{
    private readonly LinkedList<T> _elementos = new LinkedList<T>();

    public void Enqueue(T item)
    {
        _elementos.AddLast(item);
    }

    public T Dequeue()
    {
        if (_elementos.Count == 0)
            throw new InvalidOperationException("Fila vazia");

        T primeiro = _elementos.First.Value;
        _elementos.RemoveFirst();
        return primeiro;
    }

    public T Peek()
    {
        if (_elementos.Count == 0)
            throw new InvalidOperationException("Fila vazia");

        return _elementos.First.Value;
    }

    public void SimularFilaSupermercado()
    {
        Fila<string> clientes = new Fila<string>();

        // Adiciona 5 clientes
        clientes.Enqueue("Cliente 1");
        clientes.Enqueue("Cliente 2");
        clientes.Enqueue("Cliente 3");
        clientes.Enqueue("Cliente 4");
        clientes.Enqueue("Cliente 5");

        // Atende os clientes (remove da fila)
        while (clientes.Peek() != null)
        {
            Console.WriteLine($"Atendendo: {clientes.Dequeue()}");
            if (clientes.Peek() == null) break; // Evita exceção
        }
    }
}