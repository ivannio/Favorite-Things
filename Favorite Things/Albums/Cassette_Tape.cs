using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Albums
{
    class Cassette_Tape : Album
    {
        public bool NeedsRewinding { get; set; }

        public void Rewind()
        {
            if (NeedsRewinding)
            {
                Console.WriteLine($"You started rewinding {Title} by {Artist}");
            }
            else Console.WriteLine("It's already rewound");
        }
    }
}
