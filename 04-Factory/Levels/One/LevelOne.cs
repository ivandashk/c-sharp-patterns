using System;

namespace Factory
{
    class LevelOne : Level
    {
        public LevelOne()
        {
            Console.WriteLine("Entering level 1");
            EnemyFactory = new LevelOneEnemyFactory();
        }
    }
}
