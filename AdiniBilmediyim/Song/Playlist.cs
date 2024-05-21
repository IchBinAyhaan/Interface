

namespace Playlist
{
    public class Playlist
    {
        private Song[] songs;
        private int count;

        public Playlist()
        {
            songs = new Song[10]; 
            count = 0; 
        }

    
        public void AddSong(Song song)
        {
        
            if (count == songs.Length)
            {
                Array.Resize(ref songs, songs.Length * 2);
            }

            songs[count++] = song;
        }

   
        public Song[] GetAllSongsByGenre(MusicGenre genre)
        {
        
            int genreCount = 0;
            foreach (var song in songs)
            {
                if (song != null && song.Genre == genre)
                {
                    genreCount++;
                }
            }

      
            if (genreCount == 0 || count == 0)
            {
                return null;
            }

            
            Song[] genreSongs = new Song[genreCount];
            int index = 0;
            foreach (var song in songs)
            {
                if (song != null && song.Genre == genre)
                {
                    genreSongs[index++] = song;
                }
            }

            return genreSongs;
        }
    }
}