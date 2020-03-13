using System;

namespace Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            // P E T S

            var biscuit = new Pet()
            {
                Name = "Biscuit",
                PetType = PetType.Cat,
                YearsOld = 2,
                IsChonky = true
            };
            var basil = new Pet()
            {
                Name = "Basil",
                PetType = PetType.Dog,
                YearsOld = 3,
                IsChonky = true,
            };
            biscuit.SlowlyPushSomethingOffOfTheTable();
            basil.Talk();

            // B U R R I T O S

            var beanAndCheeseBurrito = new Burrito()
            {
                BurritoType = BurritoType.Bean,
                Vegetarian = true
            };
            var baconEggAndCheeseBurrito = new Burrito()
            {
                BurritoType = BurritoType.Breakfast,
                Vegetarian = false
            };
            beanAndCheeseBurrito.OfferToVegetarianFriend();
            baconEggAndCheeseBurrito.GetConsumed();

            // A L B U M S

            var moonSafari = new Album()
            {
                Title = "Moon Safari",
                Genre = "Electronica/Dance",
                Artist = "Air",
                NumberOfTracks = 10
            };
            var plasticBeach = new Album()
            {
                Title = "Plastic Beach",
                Genre = "Pop/Electronic/Hip-Hop",
                Artist = "Gorillaz",
                NumberOfTracks = 17
            };
            moonSafari.PlayRecord();
            plasticBeach.ListenToTrack11();

            // V I D E O _ G A M E S

            var celeste = new Video_Game()
            {
                Genre = "2D Platformer",
                Title = "Celeste",
                Platform = Platform.Nintendo_Switch
            };
            var gettingOverIt = new Video_Game()
            {
                Genre = "Physics/Experimental",
                Title = "Getting Over It With Bennet Foddy",
                Platform = Platform.PC
            };
            celeste.RageQuit();
            gettingOverIt.Play();
            Console.ReadLine();
        }
    }
}
