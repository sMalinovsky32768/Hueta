using System;
using System.Collections.Generic;
using System.Linq;

Console.Write("Please enter the number of integers: ");
if (int.TryParse(Console.ReadLine(), out var n))
{
    var list = new List<long>();

    for (var i = 0; i < n;)
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out var x))
        {
            list.Add(x);
            i++;
        }
        else
            Console.WriteLine("You are a moron");
    }

    Console.Write("Please enter the start index (based zero): ");
    if (int.TryParse(Console.ReadLine(), out var c))
    {
        Console.Write("Please enter the end index (based zero): ");
        if (int.TryParse(Console.ReadLine(), out var d))
        {
            if (c >= d || d >= n)
                Console.WriteLine("You are a moron");
            var newList = list.GetRange(c, d - c + 1);
            Console.WriteLine($"the sum of the numbers on the segment [{c}; {d}] is equal to {newList.Sum()}");
            if (newList.Any(l => l == 0))
                Console.WriteLine($"The sequence [{c};{d}] contains 0");
            else
                Console.WriteLine($"The sequence [{c};{d}] does not contains 0");
        }
    }
}
else
    Console.WriteLine("You are a moron");