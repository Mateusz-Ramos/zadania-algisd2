﻿//2. Napisz program konwertujący z kodu NKB do dziesiętnego

using System;

public class NKBConverter
{
    public static int ConvertNKBToDecimal(string nkb)
    {
        // Walidacja wejścia
        if (string.IsNullOrWhiteSpace(nkb))
            throw new ArgumentException("Wartość nie może być pusta.");

        foreach (char c in nkb)
        {
            if (c != '0' && c != '1')
                throw new ArgumentException("Wartość musi być 0/1.");
        }

        int decimalValue = 0;
        int length = nkb.Length;

        // Konwersja NKB do dziesiętnego
        for (int i = 0; i < length; i++)
        {
            if (nkb[i] == '1')
            {
                decimalValue += (1 << (length - i - 1)); // 1 << n = 2^n
            }
        }

        return decimalValue;
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj liczbę w kodzie NKB (binarnym):");
            string nkbInput = Console.ReadLine();

            int decimalResult = ConvertNKBToDecimal(nkbInput);

            Console.WriteLine($"Wartość dziesiętna: {decimalResult}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }
    }
}