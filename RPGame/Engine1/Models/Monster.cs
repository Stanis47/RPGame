using System;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; }

        public int RewardExperiencePoints { get; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int currentHitPoints,
            int rewardExperiencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, gold)
        {
            //ImageName = String.Format(@"C:\Users\Stanis\source\repos\RPGame\RPGame\Engine1\Images\Monsters\{0}", imageName);
            ImageName = string.Format("/Engine1;component/Images/Monsters/{0}", imageName);
            RewardExperiencePoints = rewardExperiencePoints;
        }
    }
}
