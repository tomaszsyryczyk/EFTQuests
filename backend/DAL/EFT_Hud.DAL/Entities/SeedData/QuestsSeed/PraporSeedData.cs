using System.Linq;

namespace EFT_Hud.DAL.Entities.SeedData.QuestsSeed
{
    class PraporSeedData
    {
        public static readonly Quest[] Quests = {
            new Quest  { Id = 1, Name = "Debiut", MerchantId = 1,Done = false},
            new Quest  { Id = 2, Name = "Checking", MerchantId = 1,Done = false},
            new Quest  { Id = 3, Name = "Shootout picnic", MerchantId = 1,Done = false},
            new Quest  { Id = 4, Name = "Delivery from the past", MerchantId = 1,Done = false},
            new Quest  { Id = 5, Name = "BP Depot", MerchantId = 1,Done = false},
            new Quest  { Id = 6, Name = "Bad rep evidence", MerchantId = 1,Done = false},
            new Quest  { Id = 7, Name = "Ice cream cones", MerchantId = 1,Done = false},
            new Quest  { Id = 8, Name = "Postman pat - part 1", MerchantId = 1,Done = false},
            new Quest  { Id = 9, Name = "Shaking up teller", MerchantId = 1,Done = false},
            new Quest  { Id = 10, Name = "The Punisher - part 1", MerchantId = 1,Done = false},
            new Quest  { Id = 11, Name = "The Punisher - part 2", MerchantId = 1,Done = false},
            new Quest  { Id = 12, Name = "The Punisher - part 3", MerchantId = 1,Done = false},
            new Quest  { Id = 13, Name = "The Punisher - part 4", MerchantId = 1,Done = false},
            new Quest  { Id = 14, Name = "The Punisher - part 5", MerchantId = 1,Done = false},
            new Quest  { Id = 15, Name = "The Punisher - part 6", MerchantId = 1,Done = false},
            new Quest  { Id = 16, Name = "Polikhim hobo", MerchantId = 1,Done = false},
            new Quest  { Id = 17, Name = "Big customer", MerchantId = 1,Done = false},
            new Quest  { Id = 18, Name = "No offence", MerchantId = 1,Done = false},
            new Quest  { Id = 19, Name = "Grenadier", MerchantId = 1,Done = false},
            new Quest  { Id = 20, Name = "Perfect mediator", MerchantId = 1,Done = false},
            new Quest  { Id = 21, Name = "Insomnia", MerchantId = 1,Done = false},
            new Quest  { Id = 22, Name = "Test drive - Part 1", MerchantId = 1,Done = false},
            new Quest  { Id = 23, Name = "Regulated materials", MerchantId = 1,Done = false},
        };

        public static readonly Objective[] Objectives =
        {
            new Objective {Id = 25, QuestId = 1, Count = 5, CountDone = 0, Type = ObjectiveType.Kill,Description = "Scav", LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 26, QuestId = 1, Count = 2, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 14},

            new Objective {Id = 27, QuestId = 2, Count = 1, CountDone = 0, Type = ObjectiveType.Find, ItemId = 20, LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 28, QuestId = 2, CountDone = 0, Type = ObjectiveType.Find, Description = "Find the key to the tank truck", LocationId = LocationsSeedData.Ids.Customs, Optional = true},
            new Objective {Id = 29, QuestId = 2, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 20, LocationId = LocationsSeedData.Ids.Customs},

            new Objective {Id = 30, QuestId = 3, Count = 15, CountDone = 0, Type = ObjectiveType.Kill, Description = "Scav", LocationId = LocationsSeedData.Ids.Woods},

            new Objective {Id = 31, QuestId = 4, Count = 1, CountDone = 0, Type = ObjectiveType.Find, Description = "secure case in the Tarcone Director's Office" , LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 32, QuestId = 4, Type = ObjectiveType.Deliver, Description = "swing room, on 2nd", LocationId = LocationsSeedData.Ids.Factory},
            new Objective {Id = 33, QuestId = 4, Type = ObjectiveType.Exit, LocationId = LocationsSeedData.Ids.Factory},

            new Objective {Id = 34, QuestId = 5, Type = ObjectiveType.Mark, Description = "fuel tank №1", LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 35, QuestId = 5, Type = ObjectiveType.Mark, Description = "fuel tank №2", LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 36, QuestId = 5, Type = ObjectiveType.Mark, Description = "fuel tank №3", LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 37, QuestId = 5, Type = ObjectiveType.Mark, Description = "fuel tank №4", LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 38, QuestId = 5, Type = ObjectiveType.Exit, LocationId = LocationsSeedData.Ids.Customs},

        };

        public static readonly Reward[] Rewards =
        {
            new Reward {Id = 2, QuestId = 1, Type = RewardType.Exp, Count = 600},
            new Reward {Id = 3, QuestId = 1, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 4, QuestId = 1, ItemId = ItemsSeedData.Ids.Roubles, Type = RewardType.Item, Count = 5000},
            new Reward {Id = 5, QuestId = 1, ItemId = 18, Type = RewardType.Item, Count = 1},
            new Reward {Id = 6, QuestId = 1, ItemId = 19, Type = RewardType.Item, Count = 1},
            new Reward {Id = 7, QuestId = 1, Type = RewardType.Unlock, Description = "Unlocks purchase of Kalashnikov AKS-74U 5.45x39 at LL1"},

            new Reward {Id = 8, QuestId = 2, Type = RewardType.Exp, Count = 8000},
            new Reward {Id = 9, QuestId = 2, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 10, QuestId = 2, ItemId = ItemsSeedData.Ids.Roubles, Type = RewardType.Item, Count = 4000},
            new Reward {Id = 11, QuestId = 2, Type = RewardType.Item, Count = 1, ItemId = 21},
            new Reward {Id = 12, QuestId = 2, Type = RewardType.Item, Count = 3, ItemId = 22},

            new Reward {Id = 13, QuestId = 3, Type = RewardType.Exp, Count = 2000},
            new Reward {Id = 14, QuestId = 3, Type = RewardType.PraporReputation, Count = 0.1},
            new Reward {Id = 15, QuestId = 3, Type = RewardType.Item, Count = 6000, ItemId = ItemsSeedData.Ids.Roubles},
            new Reward {Id = 16, QuestId = 3, Type = RewardType.Item, Count = 3, ItemId = 23},
            new Reward {Id = 17, QuestId = 3, Type = RewardType.Item, Count = 3, ItemId = 24},

            new Reward {Id = 18, QuestId = 4, Type = RewardType.Exp, Count = 4100},
            new Reward {Id = 19, QuestId = 4, Type = RewardType.PraporReputation, Count = 0.11},
            new Reward {Id = 20, QuestId = 4, Type = RewardType.Item, Count = 12000, ItemId = ItemsSeedData.Ids.Roubles},
            new Reward {Id = 21, QuestId = 4, Type = RewardType.Item, Count = 3, ItemId = 25},
            new Reward {Id = 22, QuestId = 4, Type = RewardType.Item, Count = 3, ItemId = 26},
            new Reward {Id = 23, QuestId = 4, Type = RewardType.Unlock, Description = "Unlocks purchase of 5.45x39 mm PS at LL1"},

            new Reward {Id = 24, QuestId = 5, Type = RewardType.Exp, Count = 2900},
            new Reward {Id = 25, QuestId = 5, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 26, QuestId = 5, Type = RewardType.JeagerReputation, Count = -0.01},
            new Reward {Id = 27, QuestId = 5, Type = RewardType.Item, Count = 8000, ItemId = ItemsSeedData.Ids.Roubles},
            new Reward {Id = 28, QuestId = 5, Type = RewardType.Item, Count = 3, ItemId = 27},
        };
    }
}
