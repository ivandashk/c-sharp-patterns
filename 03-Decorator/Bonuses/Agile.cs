namespace Decorator
{
    class Agile : IWeapon
    {
        private const string Name = "Agile";
        private readonly IWeapon _weapon;

        public Agile(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public string GetName()
        {
            return $"{Name} {_weapon.GetName()}";
        }
    }
}
