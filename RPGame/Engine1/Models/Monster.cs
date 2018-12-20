using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int _hitPoints;

        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }
        public int HitPoints
        {
            get => _hitPoints;
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster(string name, string imageName,
            int maxHitPoints, int hitPoints,
            int rewardExperiencePoints, int rewardGold)
        {
            this.Name = name;
            this.ImageName = String.Format("/Engine1;component/Images/Monsters/{0}", imageName);
            this.MaximumHitPoints = maxHitPoints;
            this.HitPoints = hitPoints;
            this.RewardExperiencePoints = rewardExperiencePoints;
            this.RewardGold = rewardGold;

            this.Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}
