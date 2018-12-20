using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class QuestStatus
    {
        public Quest PlayerQuest { get; set; }
        public bool IsCompleted { get; set; }

        public QuestStatus(Quest quest)
        {
            this.PlayerQuest = quest;
            this.IsCompleted = false;
        }
    }
}
