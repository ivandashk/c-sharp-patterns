namespace Factory
{
    class MageEnemy : Enemy
    {
        public MageEnemy(ILevelEnemyFactory level)
        {
            Name = "Mage Enemy";
            Weapon = level.CreateWeapon();
            Armor = level.CreateArmor();
        }
    }
}
