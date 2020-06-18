using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster rock = new Monster("Rock", 1000, 1000, 5, 2);

                    AddLootItem(rock, 9001, 30);
                    AddLootItem(rock, 9002, 10);

                    return rock;

                case 2:
                    Monster skeleton = new Monster("Skeleton", 2000, 2000, 8, 7);

                    AddLootItem(skeleton, 9001, 30);
                    AddLootItem(skeleton, 9002, 10);
                    AddLootItem(skeleton, 9003, 3);
                    AddLootItem(skeleton, 3, 3);

                    return skeleton;

                case 3:
                    Monster dagger = new Monster("Flying daggers", 1500, 1500, 6, 5);

                    AddLootItem(dagger, 9001, 30);
                    AddLootItem(dagger, 9002, 10);
                    AddLootItem(dagger, 2, 5);

                    return dagger;

                default:
                    throw new ArgumentException(string.Format("Monster type '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }

    }
}
