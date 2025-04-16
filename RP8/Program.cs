using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        char c = 'a';
        List<string> A = new List<string> { "ab", "aa", "abc", "a", "ba", "aaa", "cbc", "aca" };

        int count = A.Count(s => s.Length > 1 && s.StartsWith(c.ToString()) && s.EndsWith(c.ToString()));

        Console.WriteLine($"Количество подходящих строк: {count}");
    }
}
