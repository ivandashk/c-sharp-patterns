using System;

namespace Observer
{
    class StaminaBar : ICustomObserver, IDisplayable
    {
        private int _stamina;
        private readonly ICustomObservable _hero;

        public StaminaBar(ICustomObservable hero)
        {
            _hero = hero;
            hero.Subscribe(this);
        }

        public void Update()
        {
            var hero = _hero as Hero;
            if (hero == null) return;

            _stamina = hero.GetStamina();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"{GetType().Name} shows {_stamina} hp");
        }
    }
}
