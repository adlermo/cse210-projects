using System.Text.RegularExpressions;

class HidingService
{
    static private HidingService _instance = new HidingService();

    static public HidingService getInstance() { return _instance; }

    public void RandomlyHideWords(Scripture original)
    {
        Scripture modified = new Scripture();
        Regex validate = new Regex(@"[a-zA-Z.,!-;]");

        while (true)
        {
            Console.Clear();
            original.DisplayWithVerse();
            Console.WriteLine("\nEnter to continue. Type 'quit' to finish the program: ");

            List<string> hiddenTexts = new List<string>();

            // Quits the loop and end the program
            if (Console.ReadLine() == "quit") break;

            original.text.ForEach(verse =>
            {
                // Splitting my verse text into an array of words
                List<string> words = verse.Split(' ').ToList();

                int hCount = 0;
                // Iterate over all words
                for (int i = 0; i < words.Count(); i++)
                {
                    // Chooses randomly true or false to hide each word
                    bool shallHide = new Random().Next(0, 100) % 3 == 0 ? true : false;

                    if (shallHide && !words[i].Contains("_"))
                    {
                        hCount += 1;
                        words[i] = new string('_', words[i].Count());
                    }

                    if (hCount == 4) i = words.Count();
                }

                // Joining modified text verse
                verse = String.Join(' ', words);
                hiddenTexts.Add(verse);
            });

            modified.book = original.book;
            modified.chapter = original.chapter;
            modified.verse = original.verse;
            modified.text = hiddenTexts;

            original = modified;

            // Checks whether there's no longer words to hide
            if (!validate.IsMatch(String.Join("\n", hiddenTexts))) break;
        }

        Console.Clear();
        original.DisplayWithVerse();
        Console.WriteLine("\nI hope you memorized! But feel free to start it over.");
    }
}