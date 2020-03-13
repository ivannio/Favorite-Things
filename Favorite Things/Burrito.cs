using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things
{

    enum BurritoType
    { 
        Breakfast,
        Bean,
        Fried
    }
    class Burrito
    {
        public BurritoType BurritoType { get; set; }
        public bool Vegetarian { get; set; }

        public void GetConsumed()
        {
            Console.WriteLine($"MMMM just ate a delicious {BurritoType} burrito");
        }

        public void OfferToVegetarianFriend()
        {
            if (Vegetarian)
            {
                Console.WriteLine("Hey friend, have this vegetarian burrito.");
            }
            else
            { 
                Console.WriteLine("I'm sorry friend, I got nothin for you.");
            } 
        }

    }

    
}
