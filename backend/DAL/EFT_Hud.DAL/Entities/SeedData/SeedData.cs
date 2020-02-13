using Microsoft.EntityFrameworkCore;

namespace EFT_Hud.DAL.Entities.SeedData
{
    public static class SeedData
    {
        public static void CreateSeed(ModelBuilder modelBuilder)
        {
            CrateMerchants(modelBuilder);
            CreateLocations(modelBuilder);
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
