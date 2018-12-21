using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsUnique { get; set; }

        public GameItem(int itemTypeID, string name, int price, bool isUnique = false)
        {
            this.ItemTypeID = itemTypeID;
            this.Name = name;
            this.Price = price;
            this.IsUnique = isUnique;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, IsUnique);
        }
    }
}
