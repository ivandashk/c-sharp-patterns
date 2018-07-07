using System;

namespace Factory
{
    abstract class Level
    {
        protected ILevelEnemyFactory EnemyFactory { get; set; }

        public Enemy CreateEnemy(EnemyTypeEnum type)
        {
            switch (type)
            {
                case EnemyTypeEnum.Melee:
                    return new MeleeEnemy(EnemyFactory);
                case EnemyTypeEnum.Range:
                    return new RangeEnemy(EnemyFactory);
                case EnemyTypeEnum.Mage:
                    return new MageEnemy(EnemyFactory);
                default:
                    throw new Exception("Wrong Enemy Type");
            }
        }
    }
}
