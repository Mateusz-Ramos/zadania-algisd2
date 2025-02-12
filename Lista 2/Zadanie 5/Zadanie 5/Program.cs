﻿//5. Napisz rekurencyjny program generujący kolejne wyrazy ciągu Fibonacciego

using System;

class Program
{
    // Funkcja obliczająca n-ty wyraz ciągu Fibonacciego
    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        // Rekurencyjne wywołanie F(n) = F(n-1) + F(n-2)
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę (nr wyrazu ciągu Fibonacciego): ");
        int liczba = int.Parse(Console.ReadLine());
        Console.WriteLine($"Wyraz ciągu Fibonacciego na pozycji {liczba} to: {Fibonacci(liczba)}");
    }
}
