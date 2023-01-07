using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grande percentage! ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine("Congratulations, you developed very well in the course.");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("Good job, you passed the course.");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine("Unfortunately, you didn't passed the course. Put some more effort next time.");
        }
        else
        {
            letter = "F";
            Console.WriteLine("Better luck next time, you didn't passed the course.");
        }


        if (letter == "B" || letter == "C" || letter == "D")
        {
            if (grade % 10 >= 7) letter += "+";
            if (grade % 10 < 3) letter += "-";

        }

        Console.Write($"Your grade is {letter}");
    }
}