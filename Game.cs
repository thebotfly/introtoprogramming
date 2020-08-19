using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 150.0f;
            float healthRegen = 30;
            bool maxLevelReached = false;
            int damage = 50;
            int level = 1;
            bool ready = true;
            string role = "none";
            Console.WriteLine("Hello Traveler I Haven't Seen You Here Before What's Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " !" + "Please input a Role");
            Console.WriteLine("Press 1 for Thief Role");
            Console.WriteLine("Press 2 for Mage Role");
            char input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                health = 100;
                role = "Thief";
            }
            else if (input == '2')
            {
                damage = 70;
                role = "Mage";
                

            }
            else
            {
                Console.WriteLine("Invalid input. Using default stats");
            }
            
           
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any To Continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You approached a ancient tomb that speaks of a ancient legend that talks about the end of the world will you read it.");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no and start exploring the tomb");
            input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("")
            }
        }
    }
}
