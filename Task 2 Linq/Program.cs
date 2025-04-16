using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int D = 3;
        List<int> A = new List<int> { 13, 3, -13, 23, 33, 13, 43, 23, 53, 63 };

 
        var filtered = A
            .Where(n => n > 0 && n % 10 == D) // окончание на D и положительные
            .Reverse()                        // переворачиваем список
            .Distinct()                       // убираем повторы, оставляя последние вхождения
            .Reverse();                       // возвращаем исходный порядок

        Console.WriteLine("Результат:");
        foreach (var num in filtered)
        {
            Console.Write(num + " ");
        }
    }
}
