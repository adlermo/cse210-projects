using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Adler Orteney", "Inheritance");
        Console.WriteLine(a.GetSummary());

        MathAssignment b = new MathAssignment("Adler Orteney", "Fraction", "4.A", "1-4");
        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomeworkList());

        WritingAssignment c = new WritingAssignment("Adler Orteney", "Improve By Sharing", "The Clean Coder");
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWritingInformation());
    }
}