using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(int itemID, int quantity)
        {
            this.ItemID = itemID;
            this.Quantity = quantity;
        }
    }
}
