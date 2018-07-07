namespace Decorator
{
    class Holy : IWeapon
    {
        private const string Name = "Holy";
        private readonly IWeapon _weapon;

        public Holy(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public string GetName()
        {
            return $"{Name} {_weapon.GetName()}";
        }
    }
}
