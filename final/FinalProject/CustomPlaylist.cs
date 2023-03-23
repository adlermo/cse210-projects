class CustomPlaylist : Album
{
    public CustomPlaylist() : base() { }
    public CustomPlaylist(List<Media> songs, List<string> artists, string name) : base(songs, artists, name) { }

    public void RenamePlaylist(string name)
    {
        _name = name;
    }

    public override string GetName()
    {
        return $"{_name} — Custom ({GetTracks().Count()} songs)";
    }
}
