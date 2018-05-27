namespace Patterns
{
    class Hero
    {
        private IWeaponStrategy _weaponStrategy;
        
        public Hero(IWeaponStrategy weaponStrategy)
        {
            _weaponStrategy = weaponStrategy;
        }

        public void PerformUseWeapon()
        {
            _weaponStrategy.UseWeapon();
        }

        public void ChangeWeapon(IWeaponStrategy newWeaponStrategy)
        {
            _weaponStrategy = newWeaponStrategy;
        }
    }
}
