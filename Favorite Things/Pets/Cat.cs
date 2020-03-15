using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Pets
{
    class Cat : Pet
    {
        public bool IsIndoorCat { get; set; }

        public void Hunt(string preyName)
        {
            Console.WriteLine($"{Name} visciously hunted down the {preyName}");
        }
    }
}
