using Microsoft.EntityFrameworkCore;

namespace EFT_Hud.DAL.Entities
{
    public class EftHudDbContext : DbContext
    {
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemObjective> ItemObjectives { get; set; }

    }
}
