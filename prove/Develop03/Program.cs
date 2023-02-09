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
            // Console.Clear();
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
        return int.Parse(Console.ReadLine());
    }

    static Scripture continueHidding(Scripture original)
    {
        HidingService hidingService = HidingService.getInstance();
        return hidingService.RandomlyHideWords(original);
    }
}