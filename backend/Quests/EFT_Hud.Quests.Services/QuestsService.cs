using System.Collections.Generic;
using System.Linq;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Quests.Interfaces;
using EFT_Hud.Quests.Services.Dto;

namespace EFT_Hud.Quests.Services
{
    public interface IQuestsService
    {
        IEnumerable<QuestDto> GetAll();
    }

    public class QuestsService : IQuestsService
    {
        private readonly IQuestsRepository _repository;

        public QuestsService(IQuestsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<QuestDto> GetAll()
        {
            var merchants = _repository
                .GetAll()
                .Select(AutoMapperHelper.Map<Quest, QuestDto>)
                .ToList();

            return merchants;
        }
    }
}
