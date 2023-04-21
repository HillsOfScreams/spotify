using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Timers;

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

        public List<Song> ReturnSongs()
        {
            return songs;
        }
        public void deleteSong(Song song)
        {
            if (song != null)
            {
                songs.Remove(song);
            }
            else
            {
                Console.WriteLine("song not found!");
            }
        }

        public static void PrintSong(Playlist playlist)
        {
            var songs = playlist.ReturnSongs();
            Console.WriteLine("Name of playlist: " + playlist.PlaylistName);
            Console.WriteLine(" ");
            Console.WriteLine("Song(s) in this playlist: ");

            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].name);
            }
        }
        private static bool isPaused = false;
        private static bool repeatSong = false;
        private static Song? currentSong;

        public static void PlaySong(Song song)
        {
            Console.WriteLine($"Playing {song.name}");

            for (float i = song.duration; i >= 0; i--)
            {
                if (isPaused)
                {
                    Console.WriteLine($"Song paused at {i}");
                    while (isPaused)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.WriteLine($"Song resumed at {i}");
                }

                if (i == 0)
                {
                    Console.WriteLine("Song finished playing");
                    Console.WriteLine("Would you like to repeat? (3)");
                    Console.Write("press (1) to go back to the playlist menu, press (2) for main menu");
                    string? menu = Console.ReadLine();
                    if (menu == "1")
                    {
                        Program.playListSongMenu();
                    }
                    else if (menu == "2")
                    {
                        Program.mainMenu();
                    }
                    else
                    {
                        repeatSong = true;
                    }
                    break;
                }
                Console.WriteLine($"Song is now playing {i}");
                System.Threading.Thread.Sleep(1000);
            }

            if (repeatSong)
            {
                PlaySong(song);
            }
        }


        public static void PauseTimer()
        {
            isPaused = true;
        }

        public static void UnpauseTimer()
        {
            isPaused = false;
        }

        public static void RepeatSong()
        {
            repeatSong = true;
            Console.WriteLine($"Repeating {currentSong?.name}");
        }

        public void PlayRandomSongInPlaylist(List<Playlist> playlists)
        {
            Random random = new Random();
            int playlistsIndex = random.Next(playlists.Count);
            Playlist playlist = playlists[playlistsIndex];
            int songIndex = random.Next(playlist.songs.Count);
            Song song = playlist.songs[songIndex];

            Playlist.PlaySong(song);
        }
    }
}
