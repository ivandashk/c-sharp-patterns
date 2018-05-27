using System;

namespace Patterns
{
    class BareHands : IWeaponStrategy
    {
        public void UseWeapon()
        {
            Punch();
        }

        private void Punch()
        {
            Console.WriteLine("Punch in the face!");
        }
    }
}
