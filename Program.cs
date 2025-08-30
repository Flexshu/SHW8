using HeroesLibrary;
using System;
#pragma warning disable

namespace Project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose hero: 1 - ElvenKnight, 2 - MysticMuse");
            string choice = Console.ReadLine();
            Hero player;
            if (choice == "1") player = new ElvenKnight();
            else player = new MysticMuse();

            Console.WriteLine("Choose enemy: 1 - ElvenKnight, 2 - MysticMuse");
            string enemyChoice = Console.ReadLine();
            Hero enemy;
            if (enemyChoice == "1") enemy = new ElvenKnight();
            else enemy = new MysticMuse();

            Console.WriteLine("Player:");
            player.ShowStats();
            Console.WriteLine("Enemy:");
            enemy.ShowStats();

            Random rnd = new Random();

            Console.WriteLine("Battle start!");
            while (player.Health > 0 && enemy.Health > 0)
            {
                int playerDamage = rnd.Next(10, 21);
                int enemyDamage = rnd.Next(10, 21);

                Console.WriteLine("Player attacks for " + playerDamage);
                enemy.Health -= playerDamage;
                if (enemy.Health <= 0) break;

                Console.WriteLine("Enemy attacks for " + enemyDamage);
                player.Health -= enemyDamage;

                Console.WriteLine("Player HP: " + player.Health + " | Enemy HP: " + enemy.Health);
                Console.WriteLine();
            }

            if (player.Health > 0) Console.WriteLine("Player wins!");
            else Console.WriteLine("Enemy wins!");
        }
    }
}
