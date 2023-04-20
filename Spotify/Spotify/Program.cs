using System.Collections.Generic;
using static Spotify.Program;
using Spotify;

namespace Spotify
{
    internal class Program
    {

        public static List<Playlist> playlists = new List<Playlist>();
        public static List<Album> ALubmsdgawidiyaw = new List<Album>();

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to spotfy!");
            Console.WriteLine("what action would you like to take?");
            Console.WriteLine("- view albums (1)");
            Console.WriteLine("- view playlist(s) (2)");
            Console.WriteLine("- view friend(s) (3)");
            string action = Console.ReadLine();
            /* Console.WriteLine("what would you like to do?");
             Console.WriteLine("make playlist" + " TEST" + " addsong");
             string action = Console.ReadLine();
             if (action == "make playlist")
             {
                 Console.WriteLine("dis nog ni af hahaha");
             }
             else if(action == "TEST")
             {
                 Playlist testList = new Playlist("kaduwa");
                 Song macarena = new Song("macarena", "testartist", 114);
                 testList.addSongToList(macarena);
                 Playlist.PrintSong(testList);
             }
             else {
                 Console.WriteLine("neej dat kan niet");
             }
 */

            Song macarena = new Song("macarena", "testartist", 114);
            Playlist list = new Playlist("dwaiodhawoidjoawhdioaw");

            list.addSongToList(macarena);
            list.PlaySong(macarena);





        }
        
    }
}