using Pastel;

public class Entry
{
    string _userEntry;
    string _dateTime;
    string _prompt;

    // string _color;

    public Entry(string userEntry, string prompt)
    {
        this._userEntry = userEntry;
        this._prompt = prompt;
        this._dateTime = DateTime.Now.ToString();
    }

    public Entry(string userEntry, string prompt, string date)
    {
        this._userEntry = userEntry;
        this._prompt = prompt;
        this._dateTime = date;
    }

    public void Display()
    {
        Console.WriteLine("——————————————————————————————————————————————————————————————————————".Pastel(ColorScheme.KOMBU));
        Console.WriteLine($"{this._dateTime.Pastel(ColorScheme.YELLOW)} — {this._prompt.Pastel(ColorScheme.GRAY)}");
        Console.WriteLine($"{this._userEntry}\n");
    }

    public string GetEntry()
    {
        return $"{this._dateTime};{this._prompt};{this._userEntry}";
    }
}