namespace Factory
{
    class LevelTwoEnemyFactory : ILevelEnemyFactory
    {
        public IWeapon CreateWeapon()
        {
            return new TitanWeapon();
        }

        public IArmor CreateArmor()
        {
            return new LeatherArmor();
        }
    }
}
