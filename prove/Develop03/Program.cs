class Program
{
    static ScriptureService service = new ScriptureService();

    static void Main(string[] args)
    {
        Scripture reference;

        int userInput = showLibraryAndGetUserInput();
        if (userInput == 0) reference = service.ChooseRandom();
        else reference = service.ChooseOne(userInput - 1);

        while (true)
        {
            Console.Clear();
            reference.DisplayWithVerse();
            Console.WriteLine("\nEnter to continue. Type 'quit' to finish the program: ");

            // Quits the loop and end the program
            if (Console.ReadLine() == "quit") break;

            reference = continueHidding(reference);
        }
    }

    static int showLibraryAndGetUserInput()
    {
        service.DisplayLibrary();
        Console.WriteLine("0 — Random Scripture.\n");

        Console.Write("Please enter the desired index: ");
        string userInput = Console.ReadLine();
        if (userInput != "") return int.Parse(userInput);

        return 0;
    }

    static Scripture continueHidding(Scripture original)
    {
        return HidingService.getInstance().RandomlyHideWords(original);
    }
}