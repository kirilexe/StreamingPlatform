using System.Collections.Generic;

public class Artist
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Song> SongsList { get; set; }
    public List<Genre> GenreList { get; set; }
}
