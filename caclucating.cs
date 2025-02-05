using System;

class FibonacciCalculator
{
    // Рекурсивный метод для вычисления числа Фибоначчи
    public static long FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Итеративный метод для вычисления числа Фибоначчи
    public static long FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    // Метод для вычисления числа Фибоначчи с использованием мемоизации (динамическое программирование)
    public static long FibonacciMemoization(int n, long[] memo)
    {
        if (n <= 1) return n;
        if (memo[n] != -1) return memo[n];

        memo[n] = FibonacciMemoization(n - 1, memo) + FibonacciMemoization(n - 2, memo);
        return memo[n];
    }

    static void Main(string[] args)
    {
        int n = 30; // Число, до которого считаем Фибоначчи

        // Рекурсивный метод
        Console.WriteLine("Рекурсивное вычисление: ");
        Console.WriteLine($"Число Фибоначчи для {n}-го элемента: {FibonacciRecursive(n)}");

        // Итеративный метод
        Console.WriteLine("\nИтеративное вычисление: ");
        Console.WriteLine($"Число Фибоначчи для {n}-го элемента: {FibonacciIterative(n)}");

        // Мемоизация
        long[] memo = new long[n + 1];
        Array.Fill(memo, -1);
        Console.WriteLine("\nМемоизация: ");
        Console.WriteLine($"Число Фибоначчи для {n}-го элемента: {FibonacciMemoization(n, memo)}");
    }
}
