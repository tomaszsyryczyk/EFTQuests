using System.Collections.Generic;
using EFT_Hud.Locations.Services;
using EFT_Hud.Locations.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFT_Hud.Controllers
{
    public class LocationsController : EFTHudControllerBase
    {
        private readonly ILogger<QuestsController> _logger;
        private readonly ILocationsService _locationsService;

        public LocationsController(ILogger<QuestsController> logger, ILocationsService locationsService)
        {
            _locationsService = locationsService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LocationDto> Get()
        {
            var locations = _locationsService.GetAll();

            return locations;
        }

        [HttpGet("{id}")]
        public LocationDto Get(int id)
        {
            var location = _locationsService.GetDetails(id);

            return location;
        }
    }
}