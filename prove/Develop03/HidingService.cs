class HidingService
{
    static public HidingService getInstance() { return new HidingService(); }

    public Scripture RandomlyHideWords(Scripture scripture)
    {
        scripture.text.ForEach(verse =>
        {
            string[] words = verse.Split(' ');

            words[2] = new string('_', words[2].Count());
            Console.WriteLine(words[2]);

            verse = String.Join(' ', words);
            Console.WriteLine(verse);
        });

        scripture.DisplayWithVerse();

        return scripture;
    }
}