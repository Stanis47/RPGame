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

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster(string name, string imageName,
            int maxHitPoints, int hitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExperiencePoints, int rewardGold)
        {
            this.Name = name;
            this.ImageName = String.Format(@"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Monsters\{0}", imageName);
            this.MaximumHitPoints = maxHitPoints;
            this.HitPoints = hitPoints;
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
            this.RewardExperiencePoints = rewardExperiencePoints;
            this.RewardGold = rewardGold;

            this.Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}
