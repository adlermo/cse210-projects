using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = 0;

        while (opt != 4)
        {
            opt = Menu();
            StartActivity(opt);
        }
    }

    static int Menu()
    {
        Console.WriteLine("Available menu options (please enter only the number):");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit Program");
        Console.Write("Choose the activity you want to start: ");

        return int.Parse(Console.ReadLine());
    }

    static void StartActivity(int option)
    {
        switch (option)
        {
            case 1:
                {
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}