using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Burritos
{
    class Breakfast_Burrito : Burrito
    {
        public bool ContainsBacon { get; set; }

        public void ScrambleEggs()
        {
            Console.WriteLine($"Scrambled some eggs for my {(ContainsBacon ? "bacon " : "")}egg and cheese burrito");
        }
    }
}
