namespace Decorator
{
    class Sharp : IWeapon
    {
        private const string Name = "Sharp";
        private readonly IWeapon _weapon;

        public Sharp(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public string GetName()
        {
            return $"{Name} {_weapon.GetName()}";
        }
    }
}
