namespace Factory
{
    interface ILevelEnemyFactory
    {
        IWeapon CreateWeapon();
        IArmor CreateArmor();
    }
}
