using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Album
    {
        public string? albumName;
        private List<Song> songs;
        public void addSongToList(Song song)
        {
            songs.Add(song);
        }

        public Album(string kaas)
        {
            songs = new List<Song>();
            this.albumName = kaas;
        }

        public List<Song> returnSong()
        {
            return songs;
        }

        public static void PrintAlbumSong(Album album)
        {
            var songs = album.returnSong();
            Console.WriteLine("Name of album: " + album.albumName);
            Console.WriteLine(" ");
            Console.WriteLine("Song(s) in this album: ");

            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].name);
            }
        }
        public void copyAlbumToList(List<Song> album, List<Song> playlist)
        {
            foreach (Song song in album)
            {
                playlist.Add(song);
            }
        }

        public void PlayRandomSongInAlbum(List<Album> albums)
        {
            Random random = new Random();
            int albumIndex = random.Next(albums.Count);
            Album album = albums[albumIndex];
            int songIndex = random.Next(album.songs.Count);
            Song song = album.songs[songIndex];
             
            Playlist.PlaySong(song);
        }

    }
}
