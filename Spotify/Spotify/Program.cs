using System.Collections.Generic;
using static Spotify.Program;
using Spotify;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("make playlist" + " TEST" + "addsong");
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






        }
        
    }
}