using Favorite_Things.Albums;
using Favorite_Things.Burritos;
using Favorite_Things.Pets;
using Favorite_Things.Video_Games;
using System;

namespace Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            // P E T S

            var biscuit = new Cat()
            {
                Name = "Biscuit",
                PetType = PetType.Cat,
                YearsOld = 2,
                IsChonky = true,
                IsIndoorCat = true                
            };
            var basil = new Dog()
            {
                Name = "Basil",
                PetType = PetType.Dog,
                YearsOld = 3,
                IsChonky = true,
                Breed = "Puggle"
            };
            var rocky = new Rock()
            {
                Name = "Rocky",
                PetType = PetType.Rock,
                YearsOld = 1000,
                IsChonky = false
            };
            biscuit.SlowlyPushSomethingOffOfTheTable();
            biscuit.Hunt("toy mouse");
            basil.Talk();
            basil.Fetch();
            rocky.Nothing();

            // B U R R I T O S

            var beanAndCheeseBurrito = new Bean_Burrito()
            {
                BurritoType = BurritoType.Bean,
                Vegetarian = true,
                PercentBeans = 90
            };
            var baconEggAndCheeseBurrito = new Breakfast_Burrito()
            {
                BurritoType = BurritoType.Breakfast,
                Vegetarian = false,
                ContainsBacon = true
            };
            var sushiBurrito = new Sushi_Burrito()
            {
                BurritoType = BurritoType.Sushi,
                Vegetarian = false
            };
            beanAndCheeseBurrito.OfferToVegetarianFriend();
            baconEggAndCheeseBurrito.GetConsumed();
            beanAndCheeseBurrito.GetWrapped();
            baconEggAndCheeseBurrito.ScrambleEggs();
            sushiBurrito.Contemplate();

            // A L B U M S

            var moonSafari = new Cassette_Tape()
            {
                Title = "Moon Safari",
                Genre = "Electronica/Dance",
                Artist = "Air",
                NumberOfTracks = 10,
                NeedsRewinding = true
            };
            var plasticBeach = new CD()
            {
                Title = "Plastic Beach",
                Genre = "Pop/Electronic/Hip-Hop",
                Artist = "Gorillaz",
                NumberOfTracks = 17,
                IsScratched = false
            };
            var ambient1 = new Vinyl_Record()
            {
                Title = "Ambient 1 / Music For Airports",
                Genre = "Experimental",
                Artist = "Brian Eno",
                NumberOfTracks = 4,
                Weight = 180,
                Speed = 44
            };
            moonSafari.Play();
            plasticBeach.ListenToTrack11();
            moonSafari.Rewind();
            plasticBeach.Listen();
            ambient1.Spin();

            // V I D E O _ G A M E S

            var celeste = new Platformer()
            {
                Genre = "2D Platformer",
                Title = "Celeste",
                Platform = Platform.Nintendo_Switch,
                NumberOfDimensions = 2,
                Protagonist = "Madeline"
                
            };
            var gettingOverIt = new Video_Game()
            {
                Genre = "Physics/Experimental",
                Title = "Getting Over It With Bennet Foddy",
                Platform = Platform.PC
            };
            var overwatch = new FPS()
            {
                Genre = "FPS",
                Title = "Overwatch",
                Platform = Platform.PC,
                PlayersPerTeam = 6
            };
            var mother3 = new RPG()
            {
                Genre = "RPG",
                Title = "Mother 3",
                Platform = Platform.GBA,
                IsTurnBased = true
            };
            celeste.Jump();
            celeste.RageQuit();
            gettingOverIt.Play();
            overwatch.Headshot();
            mother3.Battle();
            Console.ReadLine();
        }
    }
}
