using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing default Constructor
        Fraction f = new Fraction();
        Console.WriteLine($"Fraction: {f.GetFractionString()}");
        Console.WriteLine($"Decimal: {f.GetDecimalValue()}\n");

        // Testing Constructor 1
        Fraction fTop = new Fraction(7);
        Console.WriteLine($"Fraction: {fTop.GetFractionString()}");
        Console.WriteLine($"Decimal: {fTop.GetDecimalValue()}\n");

        // Testing Constructor 2
        Fraction fBoth = new Fraction(6, 8);
        Console.WriteLine($"Fraction: {fBoth.GetFractionString()}");
        Console.WriteLine($"Decimal: {fBoth.GetDecimalValue()}\n");

        // Testing Setters
        fBoth.setTop(1);
        fBoth.setBottom(5);
        Console.WriteLine($"Fraction: {fBoth.GetFractionString()}");
        Console.WriteLine($"Decimal: {fBoth.GetDecimalValue()}\n");
    }
}