using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Video_Games
{
    class RPG : Video_Game
    {
        public bool IsTurnBased { get; set; }

        public void Battle()
        {
            if (IsTurnBased)
            {
                Console.WriteLine("You executed your attack, it is now the enemy's turn.");
            }
            else Console.WriteLine("You hacked and slashed about");            
        }
    }
}
