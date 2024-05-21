

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
       
            Playlist playlist = new Playlist();

           
            MusicGenre targetGenre = MusicGenre.Pop;
            Song[] popSongs = playlist.GetAllSongsByGenre(targetGenre);

        }
    }
}