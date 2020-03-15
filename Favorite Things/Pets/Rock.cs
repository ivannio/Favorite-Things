using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Pets
{
    class Rock : Pet
    {
        public bool IsEntertaining => false;

        public void Nothing()
        {
            Console.WriteLine("");
        }
    }
}
