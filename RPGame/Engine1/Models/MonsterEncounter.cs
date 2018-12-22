﻿namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; }
        public int ChanceOfEncountering { get; set; }

        public MonsterEncounter(int monsterID, int chanceOfEncountering)
        {
            this.MonsterID = monsterID;
            this.ChanceOfEncountering = chanceOfEncountering;
        }
    }
}
