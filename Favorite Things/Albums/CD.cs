using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Albums
{
    class CD : Album
    {
        public bool IsScratched { get; set; }

        public void Listen()
        {
            if (IsScratched)
            {
                Console.WriteLine("All I hear is skipping");
            }
            else Console.WriteLine($"{Title} by {Artist} has never sounded so good");
        }
    }
}
