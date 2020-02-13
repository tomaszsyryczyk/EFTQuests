using System.Collections.Generic;
using System.Linq;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Merchants.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFT_Hud.DAL.Repositories
{
    public class MerchantsRepository : IMerchantRepository
    {
        private readonly EftHudDbContext _context;

        public MerchantsRepository(EftHudDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Merchant> GetAll()
        {
            var merchants = _context.Merchants;

            return merchants;
        }

        public Merchant Get(int id)
        {
            
            var merchant = _context.Merchants
                .Include(x => x.Quests)
                .Single(x => x.Id == id);

            return merchant;
        }
    }
}
