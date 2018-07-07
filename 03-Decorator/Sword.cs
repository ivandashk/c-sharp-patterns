namespace Decorator
{
    class Sword : IWeapon
    {
        private const string Name = "Sword";

        public string GetName()
        {
            return Name;
        }
    }
}
