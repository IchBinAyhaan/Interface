

namespace Playlist
{
    public enum MusicGenre
    {
        Pop,
        Rock,
        Jazz,
        Classical

    }
    class Program
    {

        static void Main(string[] args)
        {

            Song song1 = new Song("Shape of you", "Ed Sheeran", new TimeSpan(00, 03, 00), Genre.Rock);
            Playlist playlist = new Playlist();
            playlist.AddSong(song1);
            playlist.GetAll();
            playlist.GetAllSongsByGenre(MusicGenre.Rock);
        }
    }
}
