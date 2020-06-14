using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> stdGameItems;

        static ItemFactory()
        {
            stdGameItems = new List<GameItem>();

            //========================ID, NAME, PRICE, MINDMG, MAXDMG, STRIKES=========================
            stdGameItems.Add(new Weapon(1, "Bronze Sword", 1, 5, 10, 1));
            stdGameItems.Add(new Weapon(2, "Bronze Daggers", 5, 3, 6, 2));
            stdGameItems.Add(new Weapon(666, "Owner", 90000, 150000, 200000, 5));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem stdItem = stdGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (stdItem != null)
            {
                return stdItem.Clone();
            }

            return null;
        }
    }
}
