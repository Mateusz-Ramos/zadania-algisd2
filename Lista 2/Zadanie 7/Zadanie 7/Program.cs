//7. Napisz program obliczający wartość symbolu newtona dla zadanych parametrów n i k.

using System;

class Program
{
    // Funkcja obliczająca silnię
    static long Silnia(int n)
    {
        long wynik = 1;
        for (int i = 1; i <= n; i++)
        {
            wynik *= i;
        }
        return wynik;
    }

    // Funkcja obliczająca symbol Newtona
    static long SymbolNewtona(int n, int k)
    {
        if (k > n)
        {
            return 0; // Symbol Newtona jest 0, gdy k > n
        }
        // Obliczamy symbol Newtona za pomocą wzoru: n! / (k! * (n-k)!)
        return Silnia(n) / (Silnia(k) * Silnia(n - k));
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Podaj k: ");
        int k = int.Parse(Console.ReadLine()); 
        Console.WriteLine($"Symbol Newtona dla n = {n} i k = {k} wynosi: {SymbolNewtona(n, k)}");
    }
}
