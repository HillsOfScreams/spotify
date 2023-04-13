using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spotify
{
    public class Song
    {
        public string name;
        public string artistName;
        public float duration;

        public Song(string name, string artistName, float duration)
        {
            this.name = name;
            this.artistName = artistName;
            this.duration = duration;
        }
    }
    public class Playlist
    {
        public string? PlaylistName;
        private List<Song> songs;
        public void addSongToList(Song song)
        {
            songs.Add(song);
        }

        public Playlist(string koek)
        {
            songs = new List<Song>();
            this.PlaylistName = koek;
        }

        public List<Song> returnSong()
        {
            return songs;
        }

        public static void PrintSong(Playlist playlist)
        {
            var songs = playlist.returnSong();
            Console.WriteLine("Name of playlist: " + playlist.PlaylistName);
            Console.WriteLine(" ");
            Console.WriteLine("Song(s) in this playlist: ");

            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].name);
            }
        }
    }
}
