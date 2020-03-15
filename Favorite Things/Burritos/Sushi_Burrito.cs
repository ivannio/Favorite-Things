using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Burritos
{
    class Sushi_Burrito : Burrito
    {
        public bool IsAGoodIdea => false;

        public void Contemplate()
        {
            Console.WriteLine("Isn't this just a massive sushi roll?");
        }
    }
}
