namespace EFT_Hud.DAL.Entities.SeedData
{
    class MerchantsSeedData
    {
        internal class Ids
        {
            internal static int Prapor = 1;
            internal static int Therapist = 2;
            internal static int Skier = 3;
            internal static int Peacekeeper = 4;
            internal static int Mechanic = 5;
            internal static int Ragman = 6;
            internal static int Jaeger = 7;
            internal static int Fence = 8;
        }

        public static readonly Merchant[] Merchants =
        {
            new Merchant {Id = Ids.Prapor, Name = "Prapor", IconName = "Prapor_Portrait.png"},
            new Merchant {Id = Ids.Therapist, Name = "Therapist", IconName = "Therapist_Portrait.png"},
            new Merchant {Id = Ids.Skier, Name = "Skier", IconName = "Skier_Portrait.png"},
            new Merchant {Id = Ids.Peacekeeper, Name = "Peacekeeper", IconName = "Peacekeeper_Portrait.png"},
            new Merchant {Id = Ids.Mechanic, Name = "Mechanic", IconName = "Mechanic_Portrait.png"},
            new Merchant {Id = Ids.Ragman, Name = "Ragman", IconName = "Ragman_Portrait.png"},
            new Merchant {Id = Ids.Jaeger, Name = "Jaeger", IconName = "Jaeger_Portrait.png"},
            new Merchant {Id = Ids.Fence, Name = "Fence", IconName = "Fence_Portrait.png"}
        };
    }
}
