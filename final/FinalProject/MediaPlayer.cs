using NAudio.Wave;

class MediaPlayer
{
    private Media _currentTrack;
    private bool _isPlaying;
    private WaveOutEvent _outputDevice;
    private List<Media> _currentPlaylist = new List<Media>();
    public void SetPlaylist(List<Media> playlist) { _currentPlaylist = playlist; Play(); }

    public MediaPlayer()
    {
        _outputDevice = new WaveOutEvent();

        Console.WriteLine(_currentPlaylist.Count);
        if (_currentPlaylist.Count - 1 < 0)
        {
            _currentPlaylist.Add(new Media("media/Medley-A.mp3", "Povos", "Adler", "Sunday"));
            _currentTrack = _currentPlaylist[0];
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine($"1. {(!_isPlaying ? "Play (|>)" : "Pause (||)")}");
        Console.WriteLine("2. Next (>>|)");
        Console.WriteLine("3. Prev (|<<)");
        Console.WriteLine("4. Stop ([])");
        Console.WriteLine("5. Library (===)");
        Console.WriteLine("0. Quit Player (X)");
    }

    public void GetNextTrack()
    {
        if (_currentPlaylist.Count - 1 > 0)
        {
            int i = _currentPlaylist.IndexOf(_currentTrack);

            // Checks if the playlist has ended
            if (i >= _currentPlaylist.Count())
                _currentTrack = _currentPlaylist[0];
            else
                _currentTrack = _currentPlaylist[i];
        }
    }

    public void GetPrevTrack()
    {
        if (_currentPlaylist.Count - 1 > 0)
        {
            int i = _currentPlaylist.IndexOf(_currentTrack);

            // Checks if the playlist has ended
            if (i <= 0)
                _currentTrack = _currentPlaylist[_currentPlaylist.Count()];
            else
                _currentTrack = _currentPlaylist[i];
        }
    }

    public void ShowPlaylist()
    {
        foreach (var m in _currentPlaylist.Select((media, index) => (media, index)))
        {
            Console.WriteLine($"{m.index + 1}. {m.media.GetInfo()}");
        }
    }

    public bool PlayOrPause() { if (_isPlaying) Pause(); else Play(); return _isPlaying; }

    private void Play()
    {
        if (_outputDevice.PlaybackState.ToString() != "Paused")
        {
            var audioFile = new AudioFileReader(_currentTrack.GetPath());
            _outputDevice.Init(audioFile);
        }
        _outputDevice.Play();

        _isPlaying = true;
    }

    private void Pause()
    {
        _outputDevice.Pause();
        _isPlaying = false;
    }

    // Stopping the player
    public void Stop() { _isPlaying = false; _currentTrack = null; _outputDevice.Stop(); }
}
