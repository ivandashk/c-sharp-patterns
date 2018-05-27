using System;
using System.Collections.Generic;

namespace Observer
{
    class Hero : ICustomObservable
    {
        private readonly List<ICustomObserver> _observers;
        private int _health;
        private int _stamina;

        public Hero()
        {
            _health = 30;
            _stamina = 20;
            _observers = new List<ICustomObserver>();
        }

        public void Subscribe(ICustomObserver observer)
        {
            _observers.Add(observer);
            NotifyObservers();
        }

        public void Unsubscribe(ICustomObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(delegate(ICustomObserver observer)
            {
                observer.Update();
            });
        }

        public int GetHealth()
        {
            return _health;
        }

        public int GetStamina()
        {
            return _stamina;
        }

        public void GotHitBy(int hp)
        {
            Console.WriteLine($"// Hero got hit by {hp} hp");
            _health -= hp;
            NotifyObservers();

            if (_health > 0) return;
            Console.WriteLine("HERO DIED");
        }

        public void LoseStamina(int sp)
        {
            Console.WriteLine($"// Hero lost {sp} stamina");
            _stamina -= sp;
            NotifyObservers();

            if (_stamina > 0) return;
            _stamina = 0;
            Console.WriteLine("HERO EXHAUSTED");
        }
    }
}
