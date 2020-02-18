using System.Collections.Generic;
using EFT_Hud.Quests.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFT_Hud.Controllers
{
    public class QuestsController : EFTHudControllerBase
    {
        private readonly ILogger<QuestsController> _logger;
        private readonly IQuestsService _questsService;

        public QuestsController(ILogger<QuestsController> logger, IQuestsService questsService)
        {
            _questsService = questsService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Quests.Services.Dto.QuestDto> Get()
        {
            var quests = _questsService.GetAll();

            return quests;
        }

        [HttpGet("merchant/{id}")]
        public IEnumerable<Quests.Services.Dto.QuestDto> GetForMerchant(int id)
        {
            var quests = _questsService.GetForMerchant(id);

            return quests;
        }
    }
}
