using EFT_Hud.DAL.Entities.SeedData.QuestsSeed;
using Microsoft.EntityFrameworkCore;

namespace EFT_Hud.DAL.Entities.SeedData
{
    public static class SeedData
    {
        public static void CreateSeed(ModelBuilder modelBuilder)
        {
            CrateMerchants(modelBuilder);
            CreateLocations(modelBuilder);
            CreateItems(modelBuilder);
            CreateQuests(modelBuilder);

        }

        private static void CreateItems(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(ItemsSeedData.Items);
        }

        private static void CreateQuests(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quest>().HasData(PraporSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(TherapisSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(SkierSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(PeacekeeperSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(MechanicSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(RagmanSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(JeagerSeedData.Quests);
            modelBuilder.Entity<Quest>().HasData(FenceSeedData.Quests);
            modelBuilder.Entity<Objective>().HasData(FenceSeedData.Objectives);
            modelBuilder.Entity<Reward>().HasData(FenceSeedData.Rewards);
        }

        private static void CreateLocations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(LocationsSeedData.Locations);
        }

        private static void CrateMerchants(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>().HasData(MerchantsSeedData.Merchants);
        }
    }
}
