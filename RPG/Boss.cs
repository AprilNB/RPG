using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    /// <summary>
    /// Represents the boss enemy in the game.
    /// </summary>
    public class Boss : Enemy
    {
        ///The default constructor.
        public Boss() : base("Big Boss")
        {
            //Set the health to be a higher value.
            Health = 150;

        }
      
    }
}
