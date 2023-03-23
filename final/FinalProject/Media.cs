
using BasicAudio;

class Media
{
    private int _duration;
    private string _name;
    private string _artist;
    private string _album;
    private AudioPlayer _audioBuffer = new AudioPlayer();

    public Media(string name, string artist, string album)
    {
        this._name = name;
        this._artist = artist;
        this._album = album;
        this._duration = 136;
    }

    public void SetAudio(AudioPlayer audio) { _audioBuffer = audio; }
    public AudioPlayer GetAudio() { return _audioBuffer; }

    public string GetInfo() { return $"{_name}\n{_album} — {_artist}"; }

    public int GetDuration() { return _duration; }
}