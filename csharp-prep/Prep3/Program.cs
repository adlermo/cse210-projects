using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean again = true;

        do
        {
            int guess;

            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 100);
            int counter = 0;

            do
            {
                Console.WriteLine("\n(Enter 0 to quit)");
                Console.Write("What's your guess for the magic number (1-100)? ");
                guess = int.Parse(Console.ReadLine());

                if (guess != 0)
                {
                    counter++;
                    if (guess != magic && guess < magic) { Console.WriteLine("Try higher"); }
                    if (guess != magic && guess > magic) { Console.WriteLine("Try lower"); }
                }
            } while (guess != 0 && guess != magic);

            if (guess != 0)
            {
                Console.WriteLine("Good job, you guessed it.");
                Console.WriteLine($"You used {counter} times to guess it.");
            }

            Console.Write("\nIf you want, enter 'yes' to play again: ");
            string prompt = Console.ReadLine();

            if (prompt != "yes") again = false;
        } while (again);
    }
}