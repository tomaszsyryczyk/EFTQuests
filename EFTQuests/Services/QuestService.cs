using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFTQuests.Data;

namespace EFTQuests.Services
{
    public class QuestService
    {
        public static List<Quest> GetQuest(Merchant value)
        {
            using (var context = new EftQuestDbContext())
            {
                var quests = context.Quests
                    .Include(x => x.Objectives)
                    .Include(x => x.ItemObjectives)
                    .Include(x => x.ItemObjectives.Select(y => y.Item))
                    .Where(x => x.Merchant.Id == value.Id)
                    .ToList();

                return quests;
            }
        }

        public static void Save(Quest newData)
        {
            using (var context = new EftQuestDbContext())
            {
                context.Quests.Attach(newData);
                context.Entry(newData).Property(x => x.Done).IsModified = true;
                context.SaveChanges();
            }
        }
    }
}
