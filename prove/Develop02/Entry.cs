using Pastel;
// EXCEEDING REQUIREMENTS: Adding colors to console outputs

public class Entry
{
    string _userEntry;
    string _dateTime;
    string _prompt;

    // string _color;

    // Base Constructor which receives only prompt and user input
    public Entry(string userEntry, string prompt)
    {
        this._userEntry = userEntry;
        this._prompt = prompt;
        this._dateTime = DateTime.Now.ToString();
    }

    // Overloaded constructor which receives date as value (made to load from file)
    public Entry(string userEntry, string prompt, string date)
    {
        this._userEntry = userEntry;
        this._prompt = prompt;
        this._dateTime = date;
    }

    // Displays my Entry object formatted correctly
    public void Display()
    {
        Console.WriteLine("——————————————————————————————————————————————————————————————————————".Pastel(ColorScheme.KOMBU));
        Console.WriteLine($"{this._dateTime.Pastel(ColorScheme.YELLOW)} — {this._prompt.Pastel(ColorScheme.GRAY)}");
        Console.WriteLine($"{this._userEntry}\n");
    }

    // FormatEntry
    public string GetEntry()
    {
        return $"{this._dateTime};{this._prompt};{this._userEntry}";
    }
}