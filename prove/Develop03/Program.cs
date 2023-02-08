using System;

class Program
{
    static ScriptureService service = new ScriptureService();
    static void Main(string[] args)
    {
        showLibraryAndGetUserInput();
    }

    static string showLibraryAndGetUserInput()
    {
        service.DisplayLibrary();

        return Console.ReadLine();
    }
}