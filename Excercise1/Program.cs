using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1 {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("歌１","歌手１",300),
                new Song("歌2","歌手2",200),
                new Song("歌3","歌手3",250),
            };
        }

        private static void PintSongs(Song[] songs) {
            foreach(var song in songs) {
                Console.WriteLine(@"{0},{1},{2\m:ss}",song.Title,song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
