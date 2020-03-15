using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things
{
    class Album
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        public int NumberOfTracks { get; set; }

        public void Play()
        {
            Console.WriteLine($"You just started playing {Title} by {Artist}.");
        }

        public void ListenToTrack11()
        {
            if (NumberOfTracks < 11)
            {
                Console.WriteLine($"Oh actually there are only {NumberOfTracks} tracks on this album");
            }
            else
            {
                Console.WriteLine($"Hell yeah... track 11 of {Title} is a bop");
            }
        }
    }
}
