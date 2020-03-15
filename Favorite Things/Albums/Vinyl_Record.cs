using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Albums
{
    class Vinyl_Record : Album
    {
        public int Weight { get; set; }
        public int Speed { get; set; }

        public void Spin()
        {
            Console.WriteLine($"Just dropped the needle on {Title} by {Artist}");
        }
    }
}
