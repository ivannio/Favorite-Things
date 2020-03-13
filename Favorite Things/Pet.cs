using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things
{
    enum PetType
    { 
        Cat,
        Dog
    }
    class Pet
    {
        public PetType PetType { get; set; }
        public string Name { get; set; }
        public int YearsOld { get; set; }
        public bool IsChonky { get; set; }

        public void SlowlyPushSomethingOffOfTheTable()
        {
            if (PetType == PetType.Cat)
            {
                Console.WriteLine($"Damnit, {Name}!");
            }
            else
            {
                Console.WriteLine("Thank you for not pushing my stuff off of the table, dog.");
            }
        }

        public void Talk()
        {
            if (PetType == PetType.Cat)
            {
                Console.WriteLine($"{Name} says meow");
            }
            else
            {
                Console.WriteLine($"{Name} says woof");
            }
        }

    }
}
