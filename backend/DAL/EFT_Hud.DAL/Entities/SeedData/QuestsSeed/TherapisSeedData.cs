using System.Linq;

namespace EFT_Hud.DAL.Entities.SeedData.QuestsSeed
{
    class TherapisSeedData
    {
        class Ids
        {
            internal static int Shortage = 25;
            internal static int Sanitary_Standards_Part_1 = 26;
            internal static int Sanitary_Standards_Part_2 = 27;
            internal static int Operation_Aquarius_Part_1 = 28;
            internal static int Operation_Aquarius_Part_2 = 29;
            internal static int Painkiller = 30;
            internal static int Pharmacist = 31;
            internal static int Supply_plans = 32;
            internal static int General_wares = 33;
            internal static int Car_repair = 34;
            internal static int Health_Care_Privacy_Part_1 = 35;
            internal static int Health_Care_Privacy_Part_2 = 36;
            internal static int Health_Care_Privacy_Part_3 = 37;
            internal static int Health_Care_Privacy_Part_4 = 38;
            internal static int Health_Care_Privacy_Part_5 = 39;
            internal static int Postman_Part_Part_2 = 40;
            internal static int Out_of_curiosity = 41;
            internal static int Trust_regain = 42;
            internal static int Hippocratic_Vow = 43;
            internal static int Private_clinic = 44;
            internal static int Athlete = 45;
            internal static int Decontamination_service = 46;
            internal static int An_apple_a_day_keeps_the_doctor_away = 47;
        }

        public static readonly Quest[] Quests = {
            new Quest  { Id = Ids.Shortage, Name = "Shortage", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Sanitary_Standards_Part_1, Name = "Sanitary Standards - Part 1", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Sanitary_Standards_Part_2, Name = "Sanitary Standards - Part 2", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Operation_Aquarius_Part_1, Name = "Operation Aquarius - Part 1", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Operation_Aquarius_Part_2, Name = "Operation Aquarius - Part 2", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Painkiller, Name = "Painkiller", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Pharmacist, Name = "Pharmacist", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Supply_plans, Name = "Supply plans", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.General_wares, Name = "General wares", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Car_repair, Name = "Car repair", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Health_Care_Privacy_Part_1, Name = "Health Care Privacy - Part 1", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Health_Care_Privacy_Part_2, Name = "Health Care Privacy - Part 2", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Health_Care_Privacy_Part_3, Name = "Health Care Privacy - Part 3", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Health_Care_Privacy_Part_4, Name = "Health Care Privacy - Part 4", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Health_Care_Privacy_Part_5, Name = "Health Care Privacy - Part 5", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Postman_Part_Part_2, Name = "Postman Pat - Part 2", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Out_of_curiosity, Name = "Out of curiosity", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Trust_regain, Name = "Trust regain", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Hippocratic_Vow, Name = "Hippocratic Vow", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Private_clinic, Name = "Private clinic", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Athlete, Name = "Athlete", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.Decontamination_service, Name = "Decontamination service", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
            new Quest  { Id = Ids.An_apple_a_day_keeps_the_doctor_away, Name = "An apple a day - keeps the doctor away", MerchantId = MerchantsSeedData.Ids.Therapist,Status = ObjectiveStatus.New},
        };

        public static readonly Objective[] Objectives =
        {

        };

        public static readonly Reward[] Rewards =
        {
        };
    }
}
