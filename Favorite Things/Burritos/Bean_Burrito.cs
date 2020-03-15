using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.Burritos
{
    class Bean_Burrito : Burrito
    {
        public int PercentBeans { get; set; }

        public void GetWrapped()
        {
            if (PercentBeans > 80)
            {
                Console.WriteLine($"This burrito would be much easier to wrap if it weren't {PercentBeans}% beans");
            }
            else Console.WriteLine("Wrappin up this bean burrito");            
        }
    }
}
