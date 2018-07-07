namespace Factory
{
    class RangeEnemy : Enemy
    {
        public RangeEnemy(ILevelEnemyFactory level)
        {
            Name = "Range Enemy";
            Weapon = level.CreateWeapon();
            Armor = level.CreateArmor();
        }
    }
}
