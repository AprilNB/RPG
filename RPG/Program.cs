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

            //While the first enemy and player are not dead, repeat the playable cycle.
            while (!firstEnemy.IsDead && !player.IsDead)
            {
                //Write out to the screen your options.
                Console.WriteLine("What would you like to do?\n\n1. Single Attack\n2. Three Strike Attack\n3. Defend\n4. Heal");

                //store what action the player chose.
                string playersAction = Console.ReadLine();

                //Check what action the player took.
                switch (playersAction)
                {
                    case "1":
                        //Write out that we choose 1.
                        Console.WriteLine("You chose to single attack the " + firstEnemy.Name + "!");

                        //Apply the attack damage to the enemy.
                        firstEnemy.GetsHit(random.Next(1, 15));

                        break;
                    case "2":
                        //Write out that we choose 2.
                        Console.WriteLine("You chose to three strike attack the " + firstEnemy.Name + "!");

                        //Loop three times to perform our multi attack.
                        for (int i = 0; i < 3; i++)
                        {
                            //Apply the attack damage to the enemy.
                            firstEnemy.GetsHit(random.Next(1, 15));
                        }

                        break;
                    case "3":
                        //Write out that we choose 3.
                        Console.WriteLine("You chose to defend!");

                        break;
                    case "4":

                        //Write out that we choose 4.
                        Console.WriteLine("You chose to Heal!");

                        break;
                    default:
                        //Let the user know they chose something else.
                        Console.WriteLine("You chose something else.");

                        break;
                }

                //Have the enemy attack the player.
                player.GetsHit(random.Next(1, 5));
            }
        }
    }
}
