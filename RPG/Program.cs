using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and store the random class.
            Random random = new Random();

            //Create the player character
            Player player = new Player();

            //Output the text stating that we want the players name.
            Console.WriteLine("What is your name?");

            //Store the players name entered.
            player.Name = Console.ReadLine();

            //Let the player know their name.
            Console.WriteLine("Thank you for entering your name, " + player.Name + ".\n");

            //Create a variable to track the first enemy.
            Enemy firstEnemy = new Enemy("Giant Enemy Crab");

            //Write out to the screen about the enemy attack.
            Console.WriteLine(player.Name + " you have encountered a " + firstEnemy.Name + "!");

            //While the first enemy is not dead, repeat the playable cycle.
            while (!firstEnemy.IsDead)
            {
                //Write out to the screen your options.
                Console.WriteLine("What would you like to do?\n\n1. Single Attack\n2. Three Strike Attack\n3. Defend\n4. Attempt To Run Away.");
                //store what action the player chose.
                string playersAction = Console.ReadLine();

                //Check what action the player took.
                if (playersAction == "1")
                {
                    //Write out that we choose 1.
                    Console.WriteLine("You chose to Single Attack the " + firstEnemy.Name + "!");

                    //Apply the attack damage to the enemy.
                    firstEnemy.GetsHit(random.Next(1, 15));
                }
                else if (playersAction == "2")
                {
                    //Write out that we choose 2.
                    Console.WriteLine("You chose to Three Strike Attack!");
                }
                else if (playersAction == "3")
                {
                    //Write out that we choose 3.
                    Console.WriteLine("You chose to Defend!");
                }
                else if (playersAction == "4")
                {
                    //Write out that we choose 4.
                    Console.WriteLine("You chose to Attempt To Run Away!");
                }
                else
                {
                    //Let the user know they chose something else.
                    Console.WriteLine("You chose something else.");
                }
            }
        }
    }
}
