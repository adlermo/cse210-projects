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

    public void Display()
    {
        Console.WriteLine("——————————————————————————————————————————————————————————————————————");
        Console.WriteLine($"{this._dateTime.Pastel(ColorScheme.YELLOW)} — {this._prompt.Pastel(ColorScheme.GRAY)}");
        Console.WriteLine($"{this._userEntry}\n");
    }

}