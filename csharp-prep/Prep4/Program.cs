using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Integer number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0) numbers.Add(input);
        } while (input != 0);

        Console.WriteLine($"\nThe sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        Console.WriteLine($"The smallest positive is {numbers.Min(n => n > 0 ? n : null)}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is: [ {String.Join(", ", numbers)} ]\n");
    }
}