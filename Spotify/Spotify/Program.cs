using System.Collections.Generic;
using static Spotify.Program;
using Spotify;
using System;
using static System.Collections.Specialized.BitVector32;
using System.Security.Cryptography.X509Certificates;

namespace Spotify
{
    internal class Program
    {
        
        public static List<Playlist> playlists = new List<Playlist>();

        public static Playlist playlist1 = new Playlist("Playlist one");

        public static Playlist playlist2 = new Playlist("Playlist two");

        public static List<Album> ALubmsdgawidiyaw = new List<Album>();

        static void Main(string[] args)
        {
            /*mainMenu();*/
            Playlist playlist1 = new Playlist("Playlist 1");
            playlist1.addSongToList(new Song("Song 13", "Artist 13", 3.6f));
            playlist1.addSongToList(new Song("Song 14", "Artist 14", 2.7f));
            playlist1.addSongToList(new Song("Song 15", "Artist 15", 4.3f));
        }

           public static void mainMenu()
            {
                Console.WriteLine("welcome to spotfy!");
                Console.WriteLine("what action would you like to take?");
                Console.WriteLine("- view albums (1)");
                Console.WriteLine("- view playlist(s) (2)");
                Console.WriteLine("- view friend(s) (3)");
                Console.WriteLine("DEV MODE (4)");
                Console.WriteLine("by selecting what you want to view you can do more actions!");
                string action = Console.ReadLine();
                if (action == "1")
                {
                    albumMenu();
                }
                else if (action == "2")
                {
                    playListSongMenu();
                }
                else if (action == "3")
                {
                    friendMenu();
                }
                else
                {
                    devMode();
                }
            }

        public static void innit()
        {

        }





        public static void devMode()
            {
                Console.WriteLine("welcome to dev mode, what's the plan?");
                Console.WriteLine("make song instances (1)");
                Console.WriteLine("make album instances (2)");
                Console.WriteLine("make playlist instances (3)");
                Console.WriteLine("make friend instances (4)");
                Console.WriteLine("back to main menu (5)");
                string devAction = Console.ReadLine();

                if (devAction == "1")
                {
                    Song song1 = new Song("Stairway to Heaven", "Led Zeppelin", 260.0f);
                    Song song2 = new Song("Bohemian Rhapsody", "Queen", 260.0f);
                    Song song3 = new Song("Smells Like Teen Spirit", "Nirvana", 260.0f);
                    Song song4 = new Song("Hotel California", "The Eagles", 260.0f);
                    Song song5 = new Song("Billie Jean", "Michael Jackson", 260.0f);
                    Song song6 = new Song("Imagine", "John Lennon", 260.0f);
                    Song song7 = new Song("Purple Haze", "Jimi Hendrix", 260.0f);
                    Song song8 = new Song("Sweet Child o' Mine", "Guns N' Roses", 260.0f);
                    Song song9 = new Song("Livin' on a Prayer", "Bon Jovi", 260.0f);
                    Song song10 = new Song("Like a Rolling Stone", "Bob Dylan", 260.0f);
                    Song song11 = new Song("Under Pressure", "Queen and David Bowie", 260.0f);
                    Song song12 = new Song("Thriller", "Michael Jackson", 260.0f);
                    Song song13 = new Song("My Heart Will Go On", "Celine Dion", 260.0f);
                    Song song14 = new Song("Nothing Else Matters", "Metallica", 260.0f);
                    Song song15 = new Song("Highway to Hell", "AC/DC", 260.0f);
                    Song song16 = new Song("November Rain", "Guns N' Roses", 260.0f);
                    Song song17 = new Song("Every Breath You Take", "The Police", 260.0f);
                    Song song18 = new Song("Radioactive", "Imagine Dragons", 260.0f);
                    Song song19 = new Song("Back in Black", "AC/DC", 260.0f);
                    Song song20 = new Song("Don't Stop Believin'", "Journey", 260.0f);

                    Console.WriteLine("20 songs made!");
                    Song[] songs = {song1, song2, song3, song4, song5, song6, song7, song8, song9, song10,
                song11, song12, song13, song14, song15, song16, song17, song18, song19, song20};

                    foreach (Song song in songs)
                    {
                        Console.WriteLine(song.name);
                    }
                    devMode();
                }



                else if(devAction == "2")
                {
                    Album album1 = new Album("Album 1");

                    Album album2 = new Album("Album 2");

                    Album album3 = new Album("Album 3");
                    
                    Console.WriteLine("3 albums made!");
                    Console.WriteLine("do you want to add songs to the album? (1) --> yes // (2) --> no // make sure there are songs before you add them!");
                    string devAction2 = Console.ReadLine();
                    if(devAction2 == "1")
                    {

                        album2.addSongToList(new Song("Song 4", "Artist 4", 260.0f));
                        album2.addSongToList(new Song("Song 5", "Artist 5", 260.0f));
                        album2.addSongToList(new Song("Song 6", "Artist 6", 260.0f));

                        album1.addSongToList(new Song("Song 1", "Artist 1", 260.0f));
                        album1.addSongToList(new Song("Song 2", "Artist 2", 260.0f));
                        album1.addSongToList(new Song("Song 3", "Artist 3", 260.0f));

                        album3.addSongToList(new Song("Song 7", "Artist 7", 260.0f));
                    }
                    else
                    {
                        Console.WriteLine("alright, no songs addes!");
                    }

                    devMode();
                }
                else if(devAction == "3")
                {
                    Playlist playlisttest = new Playlist("Playlist 1");

                    Playlist playlistmusic = new Playlist("Playlist 2");

                    Playlist playlist3 = new Playlist("Playlist 3");

                    Playlist playlist4 = new Playlist("Playlist 4");
   
                    Playlist playlist5 = new Playlist("Playlist 5");

                    Console.WriteLine("5 playlists where made");
                    Console.WriteLine("do you want to add songs? (1) --> yes // (2) --> no // make sure there are songs before you add them!");

                    string devAction3 = Console.ReadLine();

                    if(devAction3 == "1")
                    {
                        playlist5.addSongToList(new Song("Song 13", "Artist 13", 260.0f));
                        playlist5.addSongToList(new Song("Song 14", "Artist 14", 260.0f));
                        playlist5.addSongToList(new Song("Song 15", "Artist 15", 420.0f));

                        playlist4.addSongToList(new Song("Song 10", "Artist 10", 260.0f));
                        playlist4.addSongToList(new Song("Song 11", "Artist 11", 260.0f));
                        playlist4.addSongToList(new Song("Song 12", "Artist 12", 260.0f));

                        playlist3.addSongToList(new Song("Song 7", "Artist 7", 260.0f));
                        playlist3.addSongToList(new Song("Song 8", "Artist 8", 260.0f));
                        playlist3.addSongToList(new Song("Song 9", "Artist 9", 260.0f));

                        playlist2.addSongToList(new Song("Song 4", "Artist 4", 260.0f));
                        playlist2.addSongToList(new Song("Song 5", "Artist 5", 260.0f));
                        playlist2.addSongToList(new Song("Song 6", "Artist 6", 260.0f));

                        playlist1.addSongToList(new Song("Song 1", "Artist 1", 260.0f));
                        playlist1.addSongToList(new Song("Song 2", "Artist 2", 260.0f));
                        playlist1.addSongToList(new Song("Song 3", "Artist 3", 260.0f));
                    }
                }

                else if(devAction == "4")
                {
                    Console.WriteLine("making friend instances with playlists and songs!");

                    Friend friend1 = new Friend("Alice");
                    Playlist playlist1_1 = new Playlist("Chill Mix");
                    playlist1_1.addSongToList(new Song("Song A", "Artist 1", 180.0f));
                    playlist1_1.addSongToList(new Song("Song B", "Artist 2", 240.0f));
                    friend1.AddPlaylist(playlist1_1);

                    Friend friend2 = new Friend("Bob");
                    Playlist playlist2_1 = new Playlist("Gym Playlist");
                    playlist2_1.addSongToList(new Song("Song C", "Artist 3", 200.0f));
                    playlist2_1.addSongToList(new Song("Song D", "Artist 4", 300.0f));
                    friend2.AddPlaylist(playlist2_1);

                    Playlist playlist2_2 = new Playlist("Road Trip Mix");
                    playlist2_2.addSongToList(new Song("Song E", "Artist 1", 240.0f));
                    playlist2_2.addSongToList(new Song("Song F", "Artist 5", 180.0f));
                    friend2.AddPlaylist(playlist2_2);

                    Friend friend3 = new Friend("Charlie");
                    Friend friend4 = new Friend("Dave");
                    Playlist playlist4_1 = new Playlist("Study Playlist");
                    playlist4_1.addSongToList(new Song("Song G", "Artist 6", 160.0f));
                    playlist4_1.addSongToList(new Song("Song H", "Artist 4", 260.0f));
                    friend4.AddPlaylist(playlist4_1);

                    Friend friend5 = new Friend("Eve");
                    Playlist playlist5_1 = new Playlist("Party Mix");
                    playlist5_1.addSongToList(new Song("Song I", "Artist 5", 210.0f));
                    playlist5_1.addSongToList(new Song("Song J", "Artist 3", 300.0f));
                    friend5.AddPlaylist(playlist5_1);

                }



                else if (devAction == "5") {
                    mainMenu();
                }
            }

        public static void albumMenu()
            {
                Console.WriteLine("what action would you like to take?");
                Console.WriteLine("- addSongToList(Song song) (1)");
                Console.WriteLine("- returnSong() (2)");
                Console.WriteLine("- PrintAlbumSong(Album album) (3)");
                Console.WriteLine("- copyAlbumToList(List<Song> album, List<Song> playlist) (4)");
                Console.WriteLine("- PlayRandomSongInAlbum(List<Album> albums) (5)");
                Console.WriteLine("- return to main menu (6)");
                string albumAction = Console.ReadLine();

                if (albumAction == "1")
                {
                    albumMenu();
                }
                else if (albumAction == "2")
                {
                    albumMenu();
                }
                else if (albumAction == "3")
                {
                    albumMenu();
                }
                else if (albumAction == "4")
                {
                    albumMenu();
                }
                else if (albumAction == "5")
                {
                    albumMenu();
                }
                else if (albumAction == "6")
                {
                    mainMenu();
                }
            }
        public static void playListSongMenu()
            {
                Console.Write("what would you like to do?");
                Console.Write("playlists management (1) // song management (2)");
                string playAction = Console.ReadLine();
                if(playAction == "1")
                {
                    Console.WriteLine("what would you like to do in playlists?");
                Console.WriteLine("make a playlist (create)");
                    Console.WriteLine("addSongToList(Song song); (1)");
                    Console.WriteLine("ReturnSongs(); (2)");
                    Console.WriteLine("deleteSong(Song song); (3)");
                    Console.WriteLine("PrintSong(Playlist playlist) (4)");
                    Console.WriteLine("PlaySong(Song song) (5)");
                    Console.WriteLine("PlayRandomSongInPlaylist(List<Playlist> playlists) (6)");
                    string playListAction = Console.ReadLine();
                    if (playListAction == "1"){

                    }
                    else if (playListAction == "2")
                    {

                    }
                    else if (playListAction == "3")
                    {

                    }
                    else if (playListAction == "4")
                    {

                    }
                    else if (playListAction == "5")
                    {
                    foreach(Playlist playlist in playlists)
                    {
                        Playlist.PrintSong(playlist);
                    }

                    Console.Write("what song would you like to play?");
                    string? songName = Console.ReadLine();

                    Playlist.PlaySong(songName);
                    
                     }
                    else if (playListAction == "6")
                    {

                    }
                    else{
                    Console.WriteLine("whats the name of the playlist you want to create?");
                    string playlistName = Console.ReadLine();
                    Playlist kaas = new Playlist(playlistName);

                    playlists.Add(kaas);
                }
                }
                else
                {


            }
            }





        public static void friendMenu()
            {

            }

       
    }
}