using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            var hanzo = new Hero();
            Console.WriteLine($"START\nHero created with {hanzo.GetHealth()} hp and {hanzo.GetStamina()} stamina");
            hanzo.GotHitBy(3);
            hanzo.LoseStamina(1);
            hanzo.GotHitBy(2);

            Console.WriteLine("\nHEALTHBAR ADDED");
            var healthBar = new HealthBar(hanzo);
            hanzo.GotHitBy(5);

            Console.WriteLine("\nSTAMINABAR ADDED");
            var staminaBar = new StaminaBar(hanzo);
            hanzo.LoseStamina(2);
            hanzo.GotHitBy(5);

            Console.WriteLine("\nBATTLELOG ADDED");
            var battleLog = new BattleLog(hanzo);
            hanzo.GotHitBy(4);
            hanzo.LoseStamina(5);
            hanzo.GotHitBy(3);

            Console.WriteLine("\nUI REMOVED");
            hanzo.Unsubscribe(healthBar);
            hanzo.Unsubscribe(battleLog);
            hanzo.Unsubscribe(staminaBar);
            hanzo.LoseStamina(100);
            hanzo.GotHitBy(100);

            Console.ReadKey();
        }
    }
}
