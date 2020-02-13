using System.Collections.Generic;
using EFT_Hud.DAL.Entities;

namespace EFT_Hud.Merchants.Interfaces
{
    public interface IMerchantRepository
    {
        IEnumerable<Merchant> GetAll();
        Merchant Get(int id);
    }
}
