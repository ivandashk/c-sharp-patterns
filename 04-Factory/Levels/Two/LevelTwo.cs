using System;

namespace Factory
{
    class LevelTwo : Level
    {
        public LevelTwo()
        {
            Console.WriteLine("Entering level 2");
            EnemyFactory = new LevelTwoEnemyFactory();
        }
    }
}
