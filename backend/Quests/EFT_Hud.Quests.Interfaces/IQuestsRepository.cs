using System.Collections.Generic;
using EFT_Hud.DAL.Entities;

namespace EFT_Hud.Quests.Interfaces
{
    public interface IQuestsRepository
    {
        IEnumerable<Quest> GetAll();
        Quest Get(int id);
    }
}
