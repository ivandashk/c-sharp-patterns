using System;

namespace Observer
{
    class BattleLog : ICustomObserver, IDisplayable
    {
        private int _health;
        private int _stamina;
        private readonly ICustomObservable _hero;

        public BattleLog(ICustomObservable hero)
        {
            _hero = hero;
            hero.Subscribe(this);
        }

        public void Update()
        {
            var hero = _hero as Hero;
            if (hero == null) return;

            _health = hero.GetHealth();
            _stamina = hero.GetStamina();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"{GetType().Name}: Your hero has {_health} hp and {_stamina} stamina");
        }
    }
}
