﻿//4. Napisz rekurencyjną realizację obliczenia silni tworząc funkcję silnia(n);

using System;

class Program
{
    // Funkcja obliczająca silnię rekurencyjnie
    static int Silnia(int n)
    {
        // Podstawowy przypadek: silnia z 0 lub 1 to 1
        if (n == 0 || n == 1)
        {
            return 1;
        }
        // Rekurencyjne wywołanie funkcji: n! = n * (n-1)!
        else
        {
            return n * Silnia(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine()); 
        Console.WriteLine($"Silnia z {liczba} wynosi: {Silnia(liczba)}");
    }
}
