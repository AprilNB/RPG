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
        /// Determines if this player is dead.
        /// </summary>

        public bool IsDead { get; set; }

        /// <summary>
        /// The default constructor.
        /// </summary>

        public Player()
        {
            //Set the health value to 100.
            Health = 100;
        }

        /// <summary>
        /// This gets called when the player is hit.
        /// </summary>
        /// <param name="hit_value">The amount of damage the player will take.</param>

        public void GetsHit(int hit_value)
        {
            //Subtract the hit value from the health.
            Health = Health - hit_value;

            //Write out that the player got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + " damage!  You now have " + Health + " health remaining.");

            //Check if the player is dead.
            if (Health <= 0)
            {
                //The player is dead.
                Die();
            }
        }

        /// <summary>
        /// Called when the player is supposed to die.
        /// </summary>

        private void Die()
        {
            //Write to the console that the player is dead.
            Console.WriteLine(Name + " has died!");

            //Set the boolean that this player has died.
            IsDead = true;
        }
    }
}
