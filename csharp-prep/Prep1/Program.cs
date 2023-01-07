using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();

        Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
    }
}