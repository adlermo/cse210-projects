using System;

class Program
{
    static MediaPlayer player = new MediaPlayer();
    static bool _session = true;

    static void Main(string[] args)
    {
        while (_session)
        {
            Execute(DisplayPlayerMenu());
        }
    }

    private static int DisplayPlayerMenu()
    {
        Console.Clear();
        Console.WriteLine("You are using ConsoleMediaPlayer. Your minimalist Media Player!");
        Console.WriteLine();

        player.DisplayMenu();

        Console.WriteLine();
        Console.Write("Please, choose an option from the list above: ");
        return int.TryParse(Console.ReadLine(), out int i) ? i : 1;
    }

    private static void Execute(int option)
    {
        switch (option)
        {
            case 1:
                player.PlayOrPause();
                break;
            case 2:
                player.Stop();
                break;
            case 3:
                player.GetNextTrack();
                break;
            case 4:
                player.GetPrevTrack();
                break;
            case 5:
                Console.Clear();
                DisplayLibraryMenu();
                break;

            default:
                _session = false;
                break;
        }
    }

    private static int DisplayLibraryMenu()
    {
        Console.WriteLine("These are the options available: ");
        Console.WriteLine();

        Console.WriteLine("0. Back to Player");
        player.ShowPlaylist();
        Console.WriteLine();

        Console.Write("Please enter your choice: ");
        return int.TryParse(Console.ReadLine(), out int i) ? i : 0;
    }
}
