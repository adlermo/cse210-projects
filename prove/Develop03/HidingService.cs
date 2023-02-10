class HidingService
{
    static private HidingService _instance = new HidingService();

    static public HidingService getInstance() { return _instance; }

    public Scripture RandomlyHideWords(Scripture original)
    {
        Scripture modified = new Scripture();
        List<string> hiddenTexts = new List<string>();

        original.text.ForEach(verse =>
        {
            string[] words = verse.Split(' ');

            for (int i = 0; i < 10; i++)
            {
                int wIndex = new Random().Next(words.Count());
                if (!words[wIndex].Contains("_")) words[wIndex] = new string('_', words[2].Count());
                else i -= 1;
            }
            verse = String.Join(' ', words);

            hiddenTexts.Add(verse);
        });

        modified.book = original.book;
        modified.chapter = original.chapter;
        modified.verse = original.verse;
        modified.text = hiddenTexts;

        return modified;
    }
}