using BasicAudio;

class MediaPlayer
{
    private Media _currentTrack;
    private bool _isPlaying;

    private List<Media> _currentPlaylist = new List<Media>();
    public void SetPlaylist(List<Media> playlist) { _currentPlaylist = playlist; Play(); }

    public MediaPlayer()
    {
        Console.WriteLine(_currentPlaylist.Count());
        if (_currentPlaylist.Count() - 1 > 0) _currentTrack = _currentPlaylist[0];
    }

    public void GetNextTrack()
    {
        if (_currentPlaylist.Count() - 1 > 0)
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
        if (_currentPlaylist.Count() - 1 > 0)
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

    public void Stop() { _isPlaying = false; _currentTrack = null; }
    public void PlayOrPause() { if (_isPlaying) Pause(); else Play(); }
    private void Play()
    {
        _isPlaying = true;
        _currentTrack.SetAudio(new BasicAudio.AudioPlayer());
        _currentTrack.GetAudio().Filename = "./media/Medley-A.mp3";
        _currentTrack.GetAudio().Play();
    }
    private void Pause() { _isPlaying = false; }
}
