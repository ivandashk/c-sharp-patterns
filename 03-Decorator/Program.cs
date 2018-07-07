using System;

namespace Decorator
{
    class Program
    {
        private const int bonusesAmount = 3;

        static void Main()
        {
            IWeapon weapon = new Sword();
            var rnd = new Random();
            for (var i = 0; i < bonusesAmount; i++)
            {
                var randomBonus = rnd.Next(3);
                switch (randomBonus)
                {
                    case 0:
                        weapon = new Holy(weapon);
                        break;
                    case 1:
                        weapon = new Sharp(weapon);
                        break;
                    case 2:
                        weapon = new Agile(weapon);
                        break;
                    default:
                        throw new Exception("Wrong Bonus");
                }
            }

            Console.WriteLine(weapon.GetName());
            Console.ReadKey();
        }
    }
}
