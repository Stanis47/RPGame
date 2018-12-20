using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ItemQuantity> ItemsToComplete { get; set; }

        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }

        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete,
            int rewardEXP, int rewardGold, List<ItemQuantity> rewardItems)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.ItemsToComplete = itemsToComplete;
            this.RewardExperiencePoints = rewardEXP;
            this.RewardGold = rewardGold;
            this.RewardItems = rewardItems;
        }
    }
}
