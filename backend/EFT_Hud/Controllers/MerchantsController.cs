using System.Collections.Generic;
using EFT_Hud.Merchants.Services;
using EFT_Hud.Merchants.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFT_Hud.Controllers
{
    public class MerchantsController : EFTHudControllerBase
    {
        
        private readonly ILogger<MerchantsController> _logger;
        private readonly IMerchantsService _merchantsService;

        public MerchantsController(ILogger<MerchantsController> logger, IMerchantsService merchantsService)
        {
            _merchantsService = merchantsService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MerchantDto> Get()
        {
            var merchants = _merchantsService.GetAll();
            return merchants;
        }

        [HttpGet("{id}")]
        public MerchantDetailsDto Get(int id)
        {
            var result = _merchantsService.GetDetails(id);

            return result;
        }
    }
}
