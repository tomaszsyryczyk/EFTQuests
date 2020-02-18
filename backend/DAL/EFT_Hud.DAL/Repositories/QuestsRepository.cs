using System.Collections.Generic;
using System.Linq;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Quests.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFT_Hud.DAL.Repositories
{
    public class QuestsRepository : IQuestsRepository
    {
        private readonly EftHudDbContext _context;

        public QuestsRepository(EftHudDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Quest> GetAll()
        {
            var quests = _context.Quests
                .Include(x => x.Merchant)
                .Include(x => x.Objectives)
                .ThenInclude(obj => obj.Item)
                .Include(x => x.Objectives)
                .ThenInclude(obj => obj.Location)
                .Include(x => x.Rewards)
                .ThenInclude(obj => obj.Item);

            return quests;
        }

        public Quest Get(int id)
        {
            var quest = _context.Quests
                .Include(x => x.Merchant)
                .Include(x => x.Objectives)
                .Include(x => x.Rewards)
                .Single(x => x.Id == id);

            return quest;
        }
    }
}
