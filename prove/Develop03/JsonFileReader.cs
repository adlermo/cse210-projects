using System.Text.Json;

class JsonFileReader
{
    private string _filename;

    public JsonFileReader() { this._filename = "scriptures.json"; }

    public T Read<T>()
    {
        string text = File.ReadAllText(this._filename);
        return JsonSerializer.Deserialize<T>(text);
    }
}