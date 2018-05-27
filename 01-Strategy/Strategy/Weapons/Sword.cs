using System;

namespace Patterns
{
    class Sword : IWeaponStrategy
    {
        public void UseWeapon()
        {
            Slice();
        }

        private void Slice()
        {
            Console.WriteLine("Cut into pieces!");
        }
    }
}
