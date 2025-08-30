using System;
#pragma warning disable

namespace HeroesLibrary
{
    public abstract class Hero
    {
        public string Name;
        public string Weapon;
        public int Health;
        public int Karma;
        public int Magic;
        public abstract void Attack();
        public abstract void Voice();
        public void ShowStats()
        {
            Console.WriteLine(Name + " | " + Weapon + " | HP: " + Health + " | Karma: " + Karma + " | Magic: " + Magic);
        }
    }

    public class ElvenKnight : Hero
    {
        public ElvenKnight()
        {
            Name = "ElvenKnight";
            Weapon = "Sword";
            Health = 100;
            Karma = 50;
            Magic = 20;
        }
        public override void Attack() { Console.WriteLine(Name + " hits with " + Weapon); }
        public override void Voice() { Console.WriteLine(Name + " shout"); }
    }

    public class MysticMuse : Hero
    {
        public MysticMuse()
        {
            Name = "MysticMuse";
            Weapon = "Staff";
            Health = 80;
            Karma = 70;
            Magic = 100;
        }
        public override void Attack() { Console.WriteLine(Name + " casts spell"); }
        public override void Voice() { Console.WriteLine(Name + " whisper"); }
    }
}
