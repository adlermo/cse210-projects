class Program
{
    static ScriptureService service = new ScriptureService();

    static void Main(string[] args)
    {
        Scripture reference;

        int userInput = showLibraryAndGetUserInput();
        if (userInput == 0) reference = service.ChooseRandom();
        else reference = service.ChooseOne(userInput - 1);

        continuousHidding(reference);
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

    static void continuousHidding(Scripture original)
    {
        HidingService.getInstance().RandomlyHideWords(original);
    }
}