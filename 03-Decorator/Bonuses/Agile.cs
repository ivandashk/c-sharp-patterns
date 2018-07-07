namespace Decorator
{
    class Agile : IBonus
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
