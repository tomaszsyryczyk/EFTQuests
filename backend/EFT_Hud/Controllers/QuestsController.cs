using System.Collections.Generic;
using System.Linq;
using EFT_Hud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFT_Hud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestsController : ControllerBase
    {
        
        private readonly ILogger<QuestsController> _logger;

        public QuestsController(ILogger<QuestsController> logger)
        {
            _logger = logger;
        }

        public static List<QuestDto> _quests = new List<QuestDto>(){
                new QuestDto(){
                    Id = 1,
                    Name = "Testowy quest 1",
                    MerchantId = 1,
                    Requirements = new List<string>(){
                        {"req test 1"}, {"req test 2"}
                    },
                    Rewards = new List<string>(){
                        {"reward1"},{"reward 2"}, {"reward 3"}
                    },
                    ItemRequirements = new List<QuestItemRequirementDto>(){
                        new QuestItemRequirementDto(){
                            Id = 1,
                            Name = "item 1",
                            Count = 10,
                            FindInRaid = false
                        },
                        new QuestItemRequirementDto(){
                            Id = 2,
                            Name = "item 2",
                            Count = 6,
                            FindInRaid = true
                        }
                    }
                },
                new QuestDto(){
                    Id = 2,
                    Name = "Testowy quest 2",
                    MerchantId = 1,
                    Requirements = new List<string>(){
                        {"req test 21"}, {"req test 22"}
                    },
                    Rewards = new List<string>(){
                        {"reward21"},{"reward 22"}, {"reward 23"}
                    },
                    ItemRequirements = new List<QuestItemRequirementDto>(){
                        new QuestItemRequirementDto(){
                            Id = 1,
                            Count = 1,
                            Name = "item 1",
                            FindInRaid = true
                        },
                        new QuestItemRequirementDto(){
                            Id = 2,
                            Count = 2,
                            Name = "item 2",
                            FindInRaid = false
                        }
                    }
                }
                
            };

        [HttpGet]
        public IEnumerable<QuestDto> Get()
        {
            return _quests;
        }

        [HttpGet("{id}")]
        public QuestDto Get(long id)
        {
            return _quests.Find(x => x.Id == id);
        }
    }
}
