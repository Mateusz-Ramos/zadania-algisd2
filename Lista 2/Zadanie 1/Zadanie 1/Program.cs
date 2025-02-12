﻿// 1. Napisz własną implementację stosu w języku programowania. Implementacja powinna wykonywać podstawowe operacje na stosie: push, pop i peek

using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> _items;
    private int _capacity;

    public Stack(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Wartość musi być większa niż zero.");

        _capacity = capacity;
        _items = new List<T>(capacity);
    }

    // Operacja push (dodanie elementu do stosu)
    public void Push(T item)
    {
        if (_items.Count >= _capacity)
            throw new InvalidOperationException("Stack overflow.");

        _items.Add(item);
    }

    // Operacja pop (usuwa i zwraca element z stosu)
    public T Pop()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Stack underflow.");

        T item = _items[^1];
        _items.RemoveAt(_items.Count - 1);
        return item;
    }

    // Operacja peek (element z wierzchołka bez usuwania)
    public T Peek()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        return _items[^1];
    }

    // Sprawdza, czy stos jest pusty
    public bool IsEmpty()
    {
        return _items.Count == 0;
    }

    // Sprawdza, ile elementów jest na stosie
    public int Size()
    {
        return _items.Count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Tworzenie stosu o pojemności 4
            Stack<int> stack = new Stack<int>(4);


            // Więcej elementów wyjątek stack overflow
            //stack.Push(1110);
            //stack.Push(1230);
            //stack.Push(100);
            //stack.Push(165);

        
            // Dodawanie różnych elementów na stos
        
            stack.Push(7);
            stack.Push(13);
            stack.Push(99);
            stack.Push(101);

            Console.WriteLine("Wierzchołek stosu: " + stack.Peek()); // 101

            Console.WriteLine("Usunięto: " + stack.Pop()); // 101
            Console.WriteLine("Usunięto: " + stack.Pop()); // 99

            Console.WriteLine("Wierzchołek stosu po usunięciu: " + stack.Peek()); // 13

            Console.WriteLine("Rozmiar stosu: " + stack.Size()); // 2

            // Sprawdzenie pustego stosu
            while (!stack.IsEmpty())
            {
                Console.WriteLine("Usunięto: " + stack.Pop());
            }

            // Próba usunięcia elementu z pustego stosu (wyjątek)
            stack.Pop();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }
    }
}
