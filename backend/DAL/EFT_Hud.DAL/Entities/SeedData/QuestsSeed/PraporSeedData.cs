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

        };

        public static readonly Reward[] Rewards =
        {
            new Reward {Id = 2, QuestId = 1, Type = RewardType.Exp, Count = 600},
            new Reward {Id = 3, QuestId = 1, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 4, ItemId = ItemsSeedData.Ids.Roubles, QuestId = 1, Type = RewardType.Item, Count = 5000},
            new Reward {Id = 5, ItemId = 18, QuestId = 1, Type = RewardType.Item, Count = 1},
            new Reward {Id = 6, ItemId = 19, QuestId = 1, Type = RewardType.Item, Count = 1},
            new Reward {Id = 7, QuestId = 1, Type = RewardType.Unlock, Description = "Unlocks purchase of Kalashnikov AKS-74U 5.45x39 at LL1"},
        };
    }
}
