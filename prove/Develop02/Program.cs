using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal Program! \n");

        bool session = true;

        while (session)
        {
            Console.WriteLine("Please enter the number for one of the menu choices: ");
            Console.WriteLine("1. Write new Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load my Journal");
            Console.WriteLine("4. Save my Journal");
            Console.WriteLine("5. Quit my Session\n");
            Console.WriteLine("What do you want to do? ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    // New Entry Implementation
                    break;

                case "2":
                    // Display Entries Implementation
                    break;

                case "3":
                    // Load Journal Implementation
                    break;

                case "4":
                    // Save Journal Implementation
                    break;

                case "5":
                    session = false;
                    Console.WriteLine("Quitting Journal Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("This is more likely an invalid option. Please, try again.");
                    break;
            }
        }
    }
}