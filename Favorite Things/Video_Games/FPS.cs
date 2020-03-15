using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Video_Games
{
    class FPS : Video_Game
    {
        public int PlayersPerTeam { get; set; }

        public void Headshot()
        {
            Console.WriteLine("Boom, headshot!");
        }

    }
}
