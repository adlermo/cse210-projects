
using BasicAudio;

class Media
{
    private int _duration;
    private string _name;
    private string _path;
    private string _artist;
    private string _album;
    private AudioPlayer _audioBuffer = new AudioPlayer();

    public Media(string path, string name, string artist, string album)
    {
        this._path = path;
        this._name = name;
        this._artist = artist;
        this._album = album;
        this._duration = 136;
    }

    public void SetAudio(AudioPlayer audio) { _audioBuffer = audio; }
    public AudioPlayer GetAudio() { return _audioBuffer; }

    public string GetPath() { return _path; }

    public string GetInfo() { return $"{_name}\n{_album} — {_artist}"; }

    public int GetDuration() { return _duration; }
}