using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things
{
    enum Platform
    { 
        PC,
        Nintendo_Switch,
        Playstation,
        Xbox,
        GBA
    }
    class Video_Game
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public Platform Platform { get; set; }


        public void Play()
        {
            Console.WriteLine($"Just turned on my {Platform} and booted up {Title}.");
        }

        public void RageQuit()
        {
            Console.WriteLine($"Man, {Title} is one of my favorite {Genre} games, but damn if it isn't hard. I gotta take a break.");
        }
    }
}
