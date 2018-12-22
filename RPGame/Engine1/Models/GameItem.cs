namespace Engine.Models
{
    public class GameItem
    {
        public enum ItemCategory
        {
            Miscellaneous,
            Weapon
        }

        public ItemCategory Category { get; }
        public int ItemTypeID { get; }
        public string Name { get; }
        public int Price { get; }
        public bool IsUnique { get; }
        public int MinimumDamage { get; }
        public int MaximumDamage { get; }    

        public GameItem(ItemCategory category, int itemTypeID, string name, int price, bool isUnique = false,
            int minimumDamage = 0, int maximumDamage = 0)
        {
            this.Category = category;
            this.ItemTypeID = itemTypeID;
            this.Name = name;
            this.Price = price;
            this.IsUnique = isUnique;
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
        }

        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name, Price, IsUnique,
                MinimumDamage, MaximumDamage);
        }
    }
}
