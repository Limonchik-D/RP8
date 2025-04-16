using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> A = new List<int> { 49, 12, 35, 57 };
        List<int> B = new List<int> { 129, 7, 15, 92, 67 };

        var result = A
            .SelectMany(a => B
                .Where(b => a % 10 == b % 10) // сравниваем последние цифры
                .Select(b => $"{a}-{b}")     // создаём строку "a-b"
            )
            .ToList();

        Console.WriteLine("Результат:");
        foreach (var pair in result)
        {
            Console.WriteLine(pair);
        }
    }
}
