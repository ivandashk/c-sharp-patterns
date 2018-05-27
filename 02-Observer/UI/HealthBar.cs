using System;

namespace Observer
{
    class HealthBar : ICustomObserver, IDisplayable
    {
        private int _health;
        private readonly ICustomObservable _hero;

        public HealthBar(ICustomObservable hero)
        {
            _hero = hero;
            hero.Subscribe(this);
        }

        public void Update()
        {
            var hero = _hero as Hero;
            if (hero == null) return;

            _health = hero.GetHealth();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"{GetType().Name} shows {_health} hp");
        }
    }
}
