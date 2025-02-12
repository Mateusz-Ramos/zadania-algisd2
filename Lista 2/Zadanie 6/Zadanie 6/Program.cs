﻿//6. Napisz iteracyjny program obliczający kolejne wyrazy ciągu Fibonacciego

using System;

class Program
{
    static int Fibonacci(int n)
    {
        // Przypadek, gdy n = 0
        if (n == 0)
        {
            return 0;
        }

        // Zmienna do przechowywania dwóch ostatnich wyrazów ciągu
        int a = 0, b = 1;

        // Obliczanie kolejnych wyrazów ciągu
        for (int i = 2; i <= n; i++)
        {
            // Nowy wyraz to suma dwóch poprzednich
            int temp = a + b;
            a = b;
            b = temp;
        }

        // Zwracamy n-ty wyraz ciągu
        return b;
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę (nr wyrazu ciągu Fibonacciego): ");
        int liczba = int.Parse(Console.ReadLine());
        Console.WriteLine($"Wyraz ciągu Fibonacciego na pozycji {liczba} to: {Fibonacci(liczba)}");
    }
}
