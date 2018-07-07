namespace Factory
{
    class MeleeEnemy : Enemy
    {
        public MeleeEnemy(ILevelEnemyFactory level)
        {
            Name = "Melee Enemy";
            Weapon = level.CreateWeapon();
            Armor = level.CreateArmor();
        }
    }
}
