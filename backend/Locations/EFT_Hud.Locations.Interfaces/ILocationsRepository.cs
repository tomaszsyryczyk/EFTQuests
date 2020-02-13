using System.Collections.Generic;
using EFT_Hud.DAL.Entities;

namespace EFT_Hud.Locations.Interfaces
{
    public interface ILocationsRepository
    {
        IEnumerable<Location> GetAll();
        Location Get(int id);
    }
}
