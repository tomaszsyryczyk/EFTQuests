using Microsoft.EntityFrameworkCore;

namespace EFT_Hud.DAL.Entities
{
    public class EftHudDbContext : DbContext
    {
        public EftHudDbContext(DbContextOptions<EftHudDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData.SeedData.CreateSeed(modelBuilder);
        }

        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
