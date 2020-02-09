using System.Collections.Generic;
using System.Linq;
using EFT_Hud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFT_Hud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchantsController : ControllerBase
    {
        
        private readonly ILogger<MerchantsController> _logger;

        public MerchantsController(ILogger<MerchantsController> logger)
        {
            _logger = logger;
        }

        private List<MerchantDto> _merchants = new List<MerchantDto>(){
                new MerchantDto(){
                    Id = 1,
                    Name = "Prapor",
                    IconName = "Prapor_Portrait.png"
                },
                new MerchantDto(){
                    Id = 2,
                    Name = "Therapist",
                    IconName = "Therapist_Portrait.png"
                },
                new MerchantDto(){
                    Id = 3,
                    Name = "Mechanic",
                    IconName = "Mechanic_Portrait.png"
                }
            };

        [HttpGet]
        public IEnumerable<MerchantDto> Get()
        {
            return _merchants;
        }

        [HttpGet("{id}")]
        public MerchantDto Get(long Id)
        {
            var result =_merchants.Find(x => x.Id == Id);

            result.Quests = QuestsController._quests.Where(x => x.MerchantId == Id).ToList();

            return result;
        }
    }
}
