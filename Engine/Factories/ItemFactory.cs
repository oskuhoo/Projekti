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
            stdGameItems.Add(new Weapon(3, "Skull Daggers", 10, 5, 8, 3));
            stdGameItems.Add(new Weapon(666, "Owner", 90000, 150000, 200000, 5));

            //=========NPCLOOT==============ID, NAME, PRICE============================================
            stdGameItems.Add(new GameItem(9001, "Token", 100));
            stdGameItems.Add(new GameItem(9002, "Golden Token", 1000));
            stdGameItems.Add(new GameItem(9003, "Skull", 333));

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
