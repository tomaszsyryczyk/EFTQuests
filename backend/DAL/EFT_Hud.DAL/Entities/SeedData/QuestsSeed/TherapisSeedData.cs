using System.Linq;

namespace EFT_Hud.DAL.Entities.SeedData.QuestsSeed
{
    class TherapisSeedData
    {
        class Ids
        {
            internal static int Shortage = 25;
            internal static int Sanitary_Standards_Part_1 = 26;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
            internal static int Shortage = 25;
        }

        public static readonly Quest[] Quests = {
            new Quest  { Id = Ids.Shortage, Name = "Shortage", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Sanitary_Standards_Part_1, Name = "Sanitary Standards - Part 1", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
            new Quest  { Id = Ids.Debiut, Name = "Debiut", MerchantId = MerchantsSeedData.Ids.Therapist,Done = false},
        };

        public static readonly Objective[] Objectives =
        {

        };

        public static readonly Reward[] Rewards =
        {
        };
    }
}
