//3. Napisz program, który będzie obliczał wartość wyrażenia zapisanego w odwrotnej notacji polskiej.

using System;
using System.Collections.Generic;

public class RPNCalculator
{
    public static double Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            throw new ArgumentException("Wyrażenie nie może być puste.");

        List<double> list = new List<double>();

        string[] tokens = expression.Split(' ');

        foreach (string token in tokens)
        {
            if (IsNumber(token, out double number))
            {
                list.Add(number);
            }
            else
            {
                if (list.Count < 2)
                    throw new InvalidOperationException("Zbyt mała wartość w wyrażeniu.");

                double b = list[^1]; // Drugi operand
                list.RemoveAt(list.Count - 1);
                double a = list[^1]; // Pierwszy operand
                list.RemoveAt(list.Count - 1);

                switch (token)
                {
                    case "+":
                        list.Add(a + b);
                        break;
                    case "-":
                        list.Add(a - b);
                        break;
                    case "*":
                        list.Add(a * b);
                        break;
                    case "/":
                        if (b == 0)
                            throw new DivideByZeroException("Nie można dzielić przez zero.");
                        list.Add(a / b);
                        break;
                    default:
                        throw new InvalidOperationException($"Nieprawidłowy operator: {token}");
                }
            }
        }

        if (list.Count != 1)
            throw new InvalidOperationException("Wyrażenie jest niepoprawne.");

        return list[0];
    }

    private static bool IsNumber(string token, out double result)
    {
        result = 0;
        bool isNegative = false;
        int startIndex = 0;

        if (token.Length > 0 && token[0] == '-')
        {
            isNegative = true;
            startIndex = 1;
        }

        for (int i = startIndex; i < token.Length; i++)
        {
            if (token[i] < '0' || token[i] > '9')
                return false;

            result = result * 10 + (token[i] - '0');
        }

        if (isNegative)
            result = -result;

        return true;
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj wyrażenie w odwrotnej notacji polskiej (RPN) oddzielając elementy spacją:");
            string input = Console.ReadLine();

            double result = Evaluate(input);

            Console.WriteLine($"Wynik: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }
    }
}
