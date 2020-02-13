using System.Collections.Generic;
using System.Linq;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Locations.Interfaces;
using EFT_Hud.Locations.Services.Dto;

namespace EFT_Hud.Locations.Services
{
    public interface ILocationsService
    {
        IEnumerable<LocationDto> GetAll();
        LocationDetailsDto GetDetails(int id);
    }

    public class LocationsService : ILocationsService
    {
        private readonly ILocationsRepository _repository;

        public LocationsService(ILocationsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<LocationDto> GetAll()
        {
            var merchants = _repository
                .GetAll()
                .Select(AutoMapperHelper.Map<Location, LocationDto>)
                .ToList();

            return merchants;
        }

        public LocationDetailsDto GetDetails(int id)
        {
            var merchant = _repository.Get(id);
            var dto = AutoMapperHelper.Map<Location, LocationDetailsDto>(merchant);

            return dto;
        }
    }
}
