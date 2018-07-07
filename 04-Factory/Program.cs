using System;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            Level level = new LevelOne();
            level.CreateEnemy(EnemyTypeEnum.Melee).RunTowardsPlayer();
            level.CreateEnemy(EnemyTypeEnum.Range).RunTowardsPlayer();

            level = new LevelTwo();
            level.CreateEnemy(EnemyTypeEnum.Mage).RunTowardsPlayer();
            level.CreateEnemy(EnemyTypeEnum.Range).RunTowardsPlayer();
            Console.ReadKey();
        }
    }
}
