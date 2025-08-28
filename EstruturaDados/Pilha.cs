using System;
using System.Collections.Generic;

namespace ExerciciosFundamentos.EstruturasDados
{
    public class Pilha<T>
    {
        private List<T> itens = new List<T>();

        public void Push(T item)
        {
            itens.Add(item);
        }

        public T Pop()
        {
            if (itens.Count == 0)
                throw new InvalidOperationException("A pilha está vazia!");
            
            T ultimo = itens[itens.Count - 1];
            itens.RemoveAt(itens.Count - 1);
            return ultimo;
        }

        public T Peek()
        {
            if (itens.Count == 0)
                throw new InvalidOperationException("A pilha está vazia!");
            
            return itens[itens.Count - 1];
        }
    }
}
