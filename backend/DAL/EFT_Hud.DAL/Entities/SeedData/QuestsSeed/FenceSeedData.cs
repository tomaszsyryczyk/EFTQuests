namespace EFT_Hud.DAL.Entities.SeedData.QuestsSeed
{
    class FenceSeedData
    {
        class Ids
        {
            internal static int Collector = 24;
        }

        public static readonly Quest[] Quests = {
            new Quest  { Id = Ids.Collector, Name = "Collector", MerchantId = 8,Done = false},
        };

        public static readonly Objective[] Objectives =
        {
            new Objective {Id = 1,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 1},
            new Objective {Id = 2,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 2},
            new Objective {Id = 3,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 3},
            new Objective {Id = 4,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 4},
            new Objective {Id = 5,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 5},
            new Objective {Id = 6,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 6},
            new Objective {Id = 7,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 7},
            new Objective {Id = 8,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 8},
            new Objective {Id = 9,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 9},
            new Objective {Id = 10,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 10},
            new Objective {Id = 11,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 11},
            new Objective {Id = 12,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.FindInRaid, ItemId = 12},

            new Objective {Id = 13,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 1},
            new Objective {Id = 14,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 2},
            new Objective {Id = 15,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 3},
            new Objective {Id = 16,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 4},
            new Objective {Id = 17,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 5},
            new Objective {Id = 18,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 6},
            new Objective {Id = 19,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 7},
            new Objective {Id = 20,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 8},
            new Objective {Id = 21,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 9},
            new Objective {Id = 22,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 10},
            new Objective {Id = 23,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 11},
            new Objective {Id = 24,QuestId = Ids.Collector, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 12},
        };

        public static readonly Reward[] Rewards =
        {
            new Reward {Id = 1, ItemId = 13, QuestId = 24, Type = RewardType.Item, Count = 1},
        };
    }
}
