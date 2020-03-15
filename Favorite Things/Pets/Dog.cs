using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Pets
{
    class Dog : Pet
    {
        public string Breed { get; set; }

        public void Fetch()
        {
            Console.WriteLine("You went and got the thing and you brought it back to me. That's a good dog.");
        }
    }
}
