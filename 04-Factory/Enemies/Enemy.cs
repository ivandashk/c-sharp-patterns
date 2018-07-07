using System;

namespace Factory
{
    abstract class Enemy
    {
        protected string Name { get; set; }

        protected IWeapon Weapon { get; set; }

        protected IArmor Armor { get; set; }

        public void RunTowardsPlayer()
        {
            Console.WriteLine($"{Name} runs towards the player in {Armor} armor with {Weapon} weapon!");
        }
    }
}
