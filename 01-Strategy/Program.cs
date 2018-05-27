using System;

namespace Patterns
{
    class Program
    {
        static void Main()
        {
            var henry = new Hero(new BareHands());
            henry.PerformUseWeapon();
            henry.ChangeWeapon(new Sword());
            henry.PerformUseWeapon();

            Console.ReadKey();
        }
    }
}
