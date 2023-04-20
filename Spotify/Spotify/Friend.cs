using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Friend
    {
        public string Name;
        private List<Playlist> playlists;

        public Friend(string name)
        {
            playlists = new List<Playlist>();
            this.Name = name;
        }

        public void AddPlaylist(Playlist playlist)
        {
            playlists.Add(playlist);
        }

        public List<Playlist> GetPlaylists()
        {
            return playlists;
        }

        public void PrintPlaylists()
        {
            Console.WriteLine("{0} playlists:", Name);
            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("- {0}", playlist.PlaylistName);
            }
        }

        public void PrintPlaylistSongs(string playlistName)
        {
            foreach (Playlist playlist in playlists)
            {
                if (playlist.PlaylistName == playlistName)
                {
                    Console.WriteLine("{0} songs:", playlistName);
                    foreach (Song song in playlist.ReturnSongs())
                    {
                        Console.WriteLine("- {0} by {1} ({2} seconds)", song.name, song.artistName, song.duration);
                    }
                    return;
                }
            }
            Console.WriteLine("Playlist {0} not found for {1}", playlistName, Name);
        }
        public static void ComparePlaylists(Playlist playlist1, Playlist playlist2)
        {
            HashSet<string> set1 = new HashSet<string>();
            foreach (Song song in playlist1.ReturnSongs())
            {
                set1.Add(song.name);
            }

            HashSet<string> set2 = new HashSet<string>();
            foreach (Song song in playlist2.ReturnSongs())
            {
                set2.Add(song.name);
            }

            set1.IntersectWith(set2);
            if (set1.Count == 0)
            {
                Console.WriteLine("No songs found in common.");
            }
            else
            {
                Console.WriteLine("Songs in common:");
                foreach (string name in set1)
                {
                    Console.WriteLine("- {0}", name);
                }
            }
        }
    }
}
