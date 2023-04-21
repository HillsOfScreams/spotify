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
        public static List<Album> ALubmsdgawidiyaw = new List<Album>();

        static void Main(string[] args)
        {
            mainMenu();

            void mainMenu()
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







            void devMode()
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
                    Song song1 = new Song("Stairway to Heaven", "Led Zeppelin", 8.02f);
                    Song song2 = new Song("Bohemian Rhapsody", "Queen", 5.55f);
                    Song song3 = new Song("Smells Like Teen Spirit", "Nirvana", 4.38f);
                    Song song4 = new Song("Hotel California", "The Eagles", 6.30f);
                    Song song5 = new Song("Billie Jean", "Michael Jackson", 4.54f);
                    Song song6 = new Song("Imagine", "John Lennon", 3.03f);
                    Song song7 = new Song("Purple Haze", "Jimi Hendrix", 2.50f);
                    Song song8 = new Song("Sweet Child o' Mine", "Guns N' Roses", 5.55f);
                    Song song9 = new Song("Livin' on a Prayer", "Bon Jovi", 4.09f);
                    Song song10 = new Song("Like a Rolling Stone", "Bob Dylan", 6.13f);
                    Song song11 = new Song("Under Pressure", "Queen and David Bowie", 4.04f);
                    Song song12 = new Song("Thriller", "Michael Jackson", 5.58f);
                    Song song13 = new Song("My Heart Will Go On", "Celine Dion", 4.40f);
                    Song song14 = new Song("Nothing Else Matters", "Metallica", 6.28f);
                    Song song15 = new Song("Highway to Hell", "AC/DC", 3.29f);
                    Song song16 = new Song("November Rain", "Guns N' Roses", 8.57f);
                    Song song17 = new Song("Every Breath You Take", "The Police", 4.13f);
                    Song song18 = new Song("Radioactive", "Imagine Dragons", 3.06f);
                    Song song19 = new Song("Back in Black", "AC/DC", 4.14f);
                    Song song20 = new Song("Don't Stop Believin'", "Journey", 4.11f);

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

                        album2.addSongToList(new Song("Song 4", "Artist 4", 3.8f));
                        album2.addSongToList(new Song("Song 5", "Artist 5", 4.0f));
                        album2.addSongToList(new Song("Song 6", "Artist 6", 2.5f));

                        album1.addSongToList(new Song("Song 1", "Artist 1", 3.5f));
                        album1.addSongToList(new Song("Song 2", "Artist 2", 4.2f));
                        album1.addSongToList(new Song("Song 3", "Artist 3", 2.9f));

                        album3.addSongToList(new Song("Song 7", "Artist 7", 3.3f));
                    }
                    else
                    {
                        Console.WriteLine("alright, no songs addes!");
                    }

                    devMode();
                }
                else if(devAction == "3")
                {
                    Playlist playlist1 = new Playlist("Playlist 1");

                    Playlist playlist2 = new Playlist("Playlist 2");

                    Playlist playlist3 = new Playlist("Playlist 3");

                    Playlist playlist4 = new Playlist("Playlist 4");
   
                    Playlist playlist5 = new Playlist("Playlist 5");

                    Console.WriteLine("5 playlists where made");
                    Console.WriteLine("do you want to add songs? (1) --> yes // (2) --> no // make sure there are songs before you add them!");

                    string devAction3 = Console.ReadLine();

                    if(devAction3 == "1")
                    {
                        playlist5.addSongToList(new Song("Song 13", "Artist 13", 3.6f));
                        playlist5.addSongToList(new Song("Song 14", "Artist 14", 2.7f));
                        playlist5.addSongToList(new Song("Song 15", "Artist 15", 4.3f));

                        playlist4.addSongToList(new Song("Song 10", "Artist 10", 2.8f));
                        playlist4.addSongToList(new Song("Song 11", "Artist 11", 4.5f));
                        playlist4.addSongToList(new Song("Song 12", "Artist 12", 3.2f));

                        playlist3.addSongToList(new Song("Song 7", "Artist 7", 3.3f));
                        playlist3.addSongToList(new Song("Song 8", "Artist 8", 3.7f));
                        playlist3.addSongToList(new Song("Song 9", "Artist 9", 4.1f));

                        playlist2.addSongToList(new Song("Song 4", "Artist 4", 3.8f));
                        playlist2.addSongToList(new Song("Song 5", "Artist 5", 4.0f));
                        playlist2.addSongToList(new Song("Song 6", "Artist 6", 2.5f));

                        playlist1.addSongToList(new Song("Song 1", "Artist 1", 3.5f));
                        playlist1.addSongToList(new Song("Song 2", "Artist 2", 4.2f));
                        playlist1.addSongToList(new Song("Song 3", "Artist 3", 2.9f));
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

            void albumMenu()
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
            void playListSongMenu()
            {
                Console.Write("what would you like to do?");
                Console.Write("playlists management (1) // song management (2)");
                string playAction = Console.ReadLine();
                if(playAction == "1")
                {
                    Console.Write("what would you like to do in playlists?");
                    
                    Console.Write("addSongToList(Song song); (1)");
                    Console.Write("ReturnSongs(); (2)");
                    Console.Write("deleteSong(Song song); (3)");
                    Console.Write("PrintSong(Playlist playlist) (4)");
                    Console.Write("PlaySong(Song song) (5)");
                    Console.Write("PlayRandomSongInPlaylist(List<Playlist> playlists) (6)");
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
                        Console.Write("what song would you like to play?");
                        string? songName = Console.ReadLine();
                        


                            Playlist.PlaySong(songName);
                        

                    }
                    else if (playListAction == "6")
                    {

                    }
                }
                else
                {

                }
            }





            void friendMenu()
            {

            }

        }
        
    }
}