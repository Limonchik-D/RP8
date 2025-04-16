using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> A = new List<string> { "abc123", "45d6", "78e90", "hello1" };

        // Используем SelectMany, чтобы выбрать все цифры из каждой строки
        var digits = A
            .SelectMany(str => str.Where(c => Char.IsDigit(c))) // для каждой строки выбираем цифры
            .ToList(); // преобразуем в список

        Console.WriteLine("Цифры из строк:");
        foreach (var digit in digits)
        {
            Console.Write(digit + " ");
        }
    }
}
