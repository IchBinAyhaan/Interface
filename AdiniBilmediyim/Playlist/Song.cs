
namespace Playlist
{
    internal class Song
    { public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public MusicGenre MusicGenre { get; set; }
        public void GetDetails()
        { Console.WriteLine(); }

    }
    public enum MusicGenre
    { }

}
