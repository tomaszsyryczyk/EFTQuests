using System.Linq;

namespace EFT_Hud.DAL.Entities.SeedData.QuestsSeed
{
    class PraporSeedData
    {
        class Ids
        {
            internal static int Debiut = 1;
            internal static int Checking = 2;
            internal static int Shootout_picnic = 3;
            internal static int Delivery_from_the_past = 4;
            internal static int BP_Depot = 5;
            internal static int Bad_rep_evidence = 6;
            internal static int Ice_cream_cone = 7;
            internal static int Postman_part_part_1 = 8;
            internal static int Shaking_up_teller = 9;
            internal static int The_Punisher_part_1 = 10;
            internal static int The_Punisher_part_2 = 11;
            internal static int The_Punisher_part_3 = 12;
            internal static int The_Punisher_part_4 = 13;
            internal static int The_Punisher_part_5 = 14;
            internal static int The_Punisher_part_6 = 15;
            internal static int Polikhim_hobo = 16;
            internal static int Big_customer = 17;
            internal static int No_offence = 18;
            internal static int Grenadier = 19;
            internal static int Perfect_mediator = 20;
            internal static int Insomnia = 21;
            internal static int Test_drive_Part_1 = 22;
            internal static int Regulated_materials = 23;
        }

        public static readonly Quest[] Quests = {
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Prapor},
            new Quest  { Id = Ids.Checking, Name = "Checking", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Shootout_picnic, Name = "Shootout picnic", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Delivery_from_the_past, Name = "Delivery from the past", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.BP_Depot, Name = "BP Depot", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Bad_rep_evidence, Name = "Bad rep evidence", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Ice_cream_cone, Name = "Ice cream cones", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Postman_part_part_1, Name = "Postman part - part 1", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Shaking_up_teller, Name = "Shaking up teller", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.The_Punisher_part_1, Name = "The Punisher - part 1", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.The_Punisher_part_2, Name = "The Punisher - part 2", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.The_Punisher_part_3, Name = "The Punisher - part 3", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.The_Punisher_part_4, Name = "The Punisher - part 4", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.The_Punisher_part_5, Name = "The Punisher - part 5", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.The_Punisher_part_6, Name = "The Punisher - part 6", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Polikhim_hobo, Name = "Polikhim hobo", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Big_customer, Name = "Big customer", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.No_offence, Name = "No offence", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Grenadier, Name = "Grenadier", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Perfect_mediator, Name = "Perfect mediator", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Insomnia, Name = "Insomnia", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Test_drive_Part_1, Name = "Test drive - Part 1", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
            new Quest  { Id = Ids.Regulated_materials, Name = "Regulated materials", MerchantId = MerchantsSeedData.Ids.Prapor,Done = false},
        };

        public static readonly Objective[] Objectives =
        {
            new Objective {Id = 25, QuestId = Ids.Debiut, Count = 5, CountDone = 0, Type = ObjectiveType.Kill,Description = "Scav", LocationId = LocationsSeedData.Ids.Customs },
            new Objective {Id = 26, QuestId = Ids.Debiut, Count = 2, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 14},

            new Objective {Id = 27, QuestId = Ids.Checking, Count = 1, CountDone = 0, Type = ObjectiveType.Find, ItemId = 20, LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 28, QuestId = Ids.Checking, CountDone = 0, Type = ObjectiveType.Find, Description = "Find the key to the tank truck", LocationId = LocationsSeedData.Ids.Customs, Optional = true},
            new Objective {Id = 29, QuestId = Ids.Checking, Count = 1, CountDone = 0, Type = ObjectiveType.Handover, ItemId = 20, LocationId = LocationsSeedData.Ids.Customs},

            new Objective {Id = 30, QuestId = Ids.Shootout_picnic, Count = 15, CountDone = 0, Type = ObjectiveType.Kill, Description = "Scav", LocationId = LocationsSeedData.Ids.Woods},

            new Objective {Id = 31, QuestId = Ids.Delivery_from_the_past, Count = 1, CountDone = 0, Type = ObjectiveType.Find, Description = "secure case in the Tarcone Director's Office" , LocationId = LocationsSeedData.Ids.Customs},
            new Objective {Id = 32, QuestId = Ids.Delivery_from_the_past, Type = ObjectiveType.Deliver, Description = "swing room, on 2nd", LocationId = LocationsSeedData.Ids.Factory},
            new Objective {Id = 33, QuestId = Ids.Delivery_from_the_past, Type = ObjectiveType.Exit, LocationId = LocationsSeedData.Ids.Factory},

            new Objective {Id = 34, QuestId = Ids.BP_Depot, Type = ObjectiveType.Mark, Description = "fuel tank №1", LocationId = LocationsSeedData.Ids.Customs, UsingItemId = ItemsSeedData.Ids.Marker},
            new Objective {Id = 35, QuestId = Ids.BP_Depot, Type = ObjectiveType.Mark, Description = "fuel tank №2", LocationId = LocationsSeedData.Ids.Customs, UsingItemId = ItemsSeedData.Ids.Marker},
            new Objective {Id = 36, QuestId = Ids.BP_Depot, Type = ObjectiveType.Mark, Description = "fuel tank №3", LocationId = LocationsSeedData.Ids.Customs, UsingItemId = ItemsSeedData.Ids.Marker},
            new Objective {Id = 37, QuestId = Ids.BP_Depot, Type = ObjectiveType.Mark, Description = "fuel tank №4", LocationId = LocationsSeedData.Ids.Customs, UsingItemId = ItemsSeedData.Ids.Marker},
            new Objective {Id = 38, QuestId = Ids.BP_Depot, Type = ObjectiveType.Exit, LocationId = LocationsSeedData.Ids.Customs},

        };

        public static readonly Reward[] Rewards =
        {
            new Reward {Id = 2, QuestId = Ids.Debiut, Type = RewardType.Exp, Count = 600},
            new Reward {Id = 3, QuestId = Ids.Debiut, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 4, QuestId = Ids.Debiut, ItemId = ItemsSeedData.Ids.Roubles, Type = RewardType.Item, Count = 5000},
            new Reward {Id = 5, QuestId = Ids.Debiut, ItemId = 18, Type = RewardType.Item, Count = 1},
            new Reward {Id = 6, QuestId = Ids.Debiut, ItemId = 19, Type = RewardType.Item, Count = 1},
            new Reward {Id = 7, QuestId = Ids.Debiut, Type = RewardType.Unlock, Description = "Unlocks purchase of Kalashnikov AKS-74U 5.45x39 at LL1"},

            new Reward {Id = 8, QuestId = Ids.Checking, Type = RewardType.Exp, Count = 8000},
            new Reward {Id = 9, QuestId = Ids.Checking, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 10, QuestId = Ids.Checking, ItemId = ItemsSeedData.Ids.Roubles, Type = RewardType.Item, Count = 4000},
            new Reward {Id = 11, QuestId = Ids.Checking, Type = RewardType.Item, Count = 1, ItemId = 21},
            new Reward {Id = 12, QuestId = Ids.Checking, Type = RewardType.Item, Count = 3, ItemId = 22},

            new Reward {Id = 13, QuestId = Ids.Shootout_picnic, Type = RewardType.Exp, Count = 2000},
            new Reward {Id = 14, QuestId = Ids.Shootout_picnic, Type = RewardType.PraporReputation, Count = 0.1},
            new Reward {Id = 15, QuestId = Ids.Shootout_picnic, Type = RewardType.Item, Count = 6000, ItemId = ItemsSeedData.Ids.Roubles},
            new Reward {Id = 16, QuestId = Ids.Shootout_picnic, Type = RewardType.Item, Count = 3, ItemId = 23},
            new Reward {Id = 17, QuestId = Ids.Shootout_picnic, Type = RewardType.Item, Count = 3, ItemId = 24},

            new Reward {Id = 18, QuestId = Ids.Delivery_from_the_past, Type = RewardType.Exp, Count = 4100},
            new Reward {Id = 19, QuestId = Ids.Delivery_from_the_past, Type = RewardType.PraporReputation, Count = 0.11},
            new Reward {Id = 20, QuestId = Ids.Delivery_from_the_past, Type = RewardType.Item, Count = 12000, ItemId = ItemsSeedData.Ids.Roubles},
            new Reward {Id = 21, QuestId = Ids.Delivery_from_the_past, Type = RewardType.Item, Count = 3, ItemId = 25},
            new Reward {Id = 22, QuestId = Ids.Delivery_from_the_past, Type = RewardType.Item, Count = 3, ItemId = 26},
            new Reward {Id = 23, QuestId = Ids.Delivery_from_the_past, Type = RewardType.Unlock, Description = "Unlocks purchase of 5.45x39 mm PS at LL1"},

            new Reward {Id = 24, QuestId = Ids.BP_Depot, Type = RewardType.Exp, Count = 2900},
            new Reward {Id = 25, QuestId = Ids.BP_Depot, Type = RewardType.PraporReputation, Count = 0.08},
            new Reward {Id = 26, QuestId = Ids.BP_Depot, Type = RewardType.JeagerReputation, Count = -0.01},
            new Reward {Id = 27, QuestId = Ids.BP_Depot, Type = RewardType.Item, Count = 8000, ItemId = ItemsSeedData.Ids.Roubles},
            new Reward {Id = 28, QuestId = Ids.BP_Depot, Type = RewardType.Item, Count = 3, ItemId = 27},
        };
    }
}
