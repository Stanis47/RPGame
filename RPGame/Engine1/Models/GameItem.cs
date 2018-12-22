namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; }
        public string Name { get; }
        public int Price { get; }
        public bool IsUnique { get; }

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
