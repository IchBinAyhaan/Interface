

namespace Playlist
{
    internal class Song
    {
        public string Title { get; set; }

        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, string artist, TimeSpan duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }
        internal void GetDetails(Song song)
        {
            Console.WriteLine($"{song.Title}, {song.Artist}, {song.Duration},{song.Genre}");
        }
    }
}
