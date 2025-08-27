# 📌 Exercícios de Fundamentos em C#

Este repositório contém exercícios práticos para fortalecer conceitos de **programação orientada a objetos (POO)**, **estruturas de dados** e **algoritmos básicos** em C#.  
A ideia é treinar os fundamentos que servem de base para aprender qualquer linguagem de programação com mais facilidade.

---

## 🔹 POO em C#

### Exercício 1 – Sistema Bancário Simples

Criar um sistema de contas bancárias com:

**Classe `ContaBancaria`**
- Propriedades: `Numero`, `Titular`, `Saldo`.
- Métodos:
  - `Depositar(decimal valor)`
  - `Sacar(decimal valor)`  

**Classe `ContaCorrente`** (herda de `ContaBancaria`)
- Propriedade: `TaxaManutencao`.
- Reescrever `Sacar` para cobrar taxa fixa de R$ 1,00.  

**Classe `ContaPoupanca`** (herda de `ContaBancaria`)
- Propriedade: `TaxaJuros`.
- Método `AplicarJuros()` que aumenta o saldo.  

👉 **Exercício bônus**: Criar uma lista `List<ContaBancaria>` e usar **polimorfismo** para sacar de diferentes contas.

---

## 🔹 Estruturas de Dados

### Exercício 2 – Pilha
Implementar classe genérica `Pilha<T>` com:
- `Push(T item)` → adicionar.
- `Pop()` → remover e retornar o último.
- `Peek()` → consultar o último sem remover.

**Simulação**: histórico de navegador (voltar/avançar páginas).

---

### Exercício 3 – Fila
Implementar classe genérica `Fila<T>` com:
- `Enqueue(T item)` → adicionar no fim.
- `Dequeue()` → remover e retornar o primeiro.
- `Peek()`.

**Simulação**: fila de supermercado (5 clientes entrando e saindo).

👉 Dica: usar `List<T>` ou `LinkedList<T>` como base.

---

## 🔹 Algoritmos básicos

### Exercício 4 – Ordenação
- Implementar **Bubble Sort** para a lista `[5, 2, 9, 1, 5, 6]`.  
- Implementar **QuickSort** recursivo para ordenar lista de inteiros.  
- Comparar tempo de execução com `List.Sort()`.  

### Exercício 5 – Busca
- Implementar **Busca Binária** em lista ordenada.  
- Exemplo: procurar número **42** numa lista de 1 a 100.  

---

## 🚀 Objetivo
Esses exercícios têm como foco:
- Consolidar **fundamentos** de programação.
- Treinar **POO**, **estruturas de dados** e **algoritmos**.
- Criar base sólida para aprender novas linguagens mais rapidamente.
- Montar um **portfólio prático** no GitHub.

---
