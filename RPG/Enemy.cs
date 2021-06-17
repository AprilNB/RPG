using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    /// <summary>
    /// Represent the base elements of an enemy.
    /// </summary>
    public class Enemy
    {
        /// <summary>
        /// The health value of the enemy.
        /// </summary>
        
        public int Health { get; set; }

        /// <summary>
        /// The name of the enemy.
        /// </summary>
        
        public string Name { get; set;  }

        /// <summary>
        /// Determines if this enemy is dead.
        /// </summary>

        public bool IsDead { get; set; }

        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="name">The name we want to give to this enemy.</param>

        public Enemy(string name)
        {
            //Set the enemy's health.
            Health = 100;

            //Set the enemy name.
            Name = name;
        }

        /// <summary>
        /// This gets called when the enemy is hit.
        /// </summary>
        /// <param name="hit_value">The amount of damage the enemy will take.</param>
        
        public void GetsHit(int hit_value)
        {
            //Subtract the hit value from the health.
            Health = Health - hit_value;

            //Write out that the enemy got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + " damage!  He now has " + Health + " remaining.");

            //Check if the enemy is dead.
            if (Health <= 0)
            {
                //The enemy is dead.
                Die();
            }
        }

        /// <summary>
        /// Called when the enemy is supposed to die.
        /// </summary>
        
        private void Die()
        {
            //Write to the console that the enemy is dead.
            Console.WriteLine(Name + " has died!");

            //Set the boolean that this enemy has died.
            IsDead = true;
        }
    }
}
