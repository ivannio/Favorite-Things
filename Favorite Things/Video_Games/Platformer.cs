using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Video_Games
{
    class Platformer : Video_Game
    {
        public int NumberOfDimensions { get; set; }
        public string Protagonist { get; set; }

        public void Jump()
        {
            if (Protagonist == "Mario")
            {
                Console.WriteLine("Yahh");
            }
            else if (Protagonist == "Link")
            {
                Console.WriteLine("Huut");
            }
            else
            {
                Console.WriteLine("You jumped");
            }            
        }
    }
}
