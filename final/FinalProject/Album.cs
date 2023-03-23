class Album
{
    private List<Media> _musicList;
    private List<string> _artists;
    protected string _name;

    public Album() { }

    public Album(List<Media> songs, List<string> artists, string name)
    {
        _musicList = songs;
        _artists = artists;
        _name = name;
    }

    public List<Media> GetTracks() { return _musicList; }

    public void PlayAlbum(MediaPlayer player)
    {
        player.SetPlaylist(_musicList);
    }

    public virtual string GetName()
    {
        return $"{_name} — Original ({_musicList.Count()} songs)";
    }
}
