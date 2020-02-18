using System.Collections.Generic;
using System.Linq;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Locations.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace EFT_Hud.DAL.Repositories
{
    public class LocationsRepository : ILocationsRepository
    {
        private readonly EftHudDbContext _context;

        public LocationsRepository(EftHudDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Location> GetAll()
        {
            var locations = _context.Locations;

            return locations;
        }

        public Location Get(int id)
        {
            var location = _context.Locations
                .Single(x => x.Id == id);

            return location;
        }
    }
}
