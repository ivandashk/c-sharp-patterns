namespace Factory
{
    class LevelOneEnemyFactory : ILevelEnemyFactory
    {
        public IWeapon CreateWeapon()
        {
            return new WoodenWeapon();
        }

        public IArmor CreateArmor()
        {
            return new ClothArmor();
        }
    }
}
