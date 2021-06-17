using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    /// <summary>
    /// This class represents the playable character.
    /// </summary>

    public class Player
    {
    /// <summary>
    /// This represents the players health values.
    /// </summary>
    /// 
        public int Health { get; set; }

        /// <summary>
        /// The name of the player.
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// The default constructor.
        /// </summary>

        public Player()
        {
            //Set the health value to 100.
            Health = 100;
        }
    }
}
